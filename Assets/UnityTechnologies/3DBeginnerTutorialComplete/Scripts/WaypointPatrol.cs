using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    
    [Tooltip("Drag JohnLemon here so the ghost knows when he is looking!")]
    public Transform player;

    int m_CurrentWaypointIndex;

    void Start ()
    {
        navMeshAgent.SetDestination (waypoints[0].position);
        
        if (player == null)
        {
            player = FindFirstObjectByType<PlayerMovement>().transform;
        }
    }

    void Update ()
    {
        if (player != null)
        {
            //dot product stuff
            Vector3 directionToGhost = (transform.position - player.position).normalized;
            
            Vector3 playerForward = player.forward;
            
            float dotProduct = Vector3.Dot(playerForward, directionToGhost);
            

            if (dotProduct > 0.5f)
            {
                navMeshAgent.isStopped = true;
            }
            else
            {
                navMeshAgent.isStopped = false; 
            }
        }

        if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
        }
    }
}