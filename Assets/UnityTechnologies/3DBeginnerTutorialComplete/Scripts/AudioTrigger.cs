using UnityEngine;

public class AudioTrigger : MonoBehaviour
{

    public AudioSource showerSound;
    
    public Transform player;


    private bool m_HasPlayed = false; 


    void OnTriggerEnter(Collider other)
    {
  
        if (other.transform == player && !m_HasPlayed)
        {
            showerSound.Play();
            m_HasPlayed = true;
            Debug.Log("Audio Trap Triggered!");
        }
    }
}