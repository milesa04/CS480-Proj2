using UnityEngine;
using StealthGame;

public class EnemyColorChanger : MonoBehaviour
{
    [Header("Color State")]
    public Color calmColor = new Color(1f, 1f, 1f); 
    public Color angryRed = new Color(1f, 0f, 0f); 

    [Header("Detection Range")]
    public float transitionStartRange = 5f; 
    public float transitionEndRange = 1.5f;

    [Header("Particle Effects")]
    public ParticleSystem angryParticleCloud;
    public float maxParticleEmission = 50f;

    private Transform m_PlayerTransform;
    private Renderer m_Renderer;
    private Color m_OriginalColor;

    void Start()
    {
        m_Renderer = GetComponentInChildren<Renderer>();
        if (m_Renderer != null)
        {
            m_OriginalColor = calmColor;
        }

        var playerScript = FindFirstObjectByType<PlayerMovement>();
        if (playerScript != null)
        {
            m_PlayerTransform = playerScript.transform;
        }
    }

    void Update()
    { // lerp and particle effects
        if (m_PlayerTransform == null || m_Renderer == null) return;

        float distance = Vector3.Distance(transform.position, m_PlayerTransform.position);

        float t = Mathf.Clamp01((transitionStartRange - distance) / (transitionStartRange - transitionEndRange));

        m_Renderer.material.color = Color.Lerp(m_OriginalColor, angryRed, t);

   
        if (angryParticleCloud != null)
        {
  
            var emission = angryParticleCloud.emission;
            

            emission.rateOverTime = Mathf.Lerp(0f, maxParticleEmission, t);
        }
    }
}