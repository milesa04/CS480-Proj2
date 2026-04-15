using UnityEngine;
using UnityEngine.Serialization;

public class AudioTrigger : MonoBehaviour
{

    [FormerlySerializedAs("spookySound")]
    public AudioSource showerSound;
    
    public Transform player;


    private bool m_HasPlayed = false; 


    void OnTriggerEnter(Collider other)
    {
  
        if (other.transform == player && !m_HasPlayed && showerSound != null)
        {
            showerSound.Play();
            m_HasPlayed = true;
            Debug.Log("Audio Trap Triggered!");
        }
    }
}