using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StealthGame
{
    public class GameEnding : MonoBehaviour
    {
        public float fadeDuration = 1f;
        public float displayImageDuration = 1f;
        public GameObject player;

        public Image endScreen;
        public Image caughtScreen;
        public AudioSource exitAudio;
        public AudioSource caughtAudio;

        // DEMO ADDITION
        public Text demoTimerText;

        bool m_IsPlayerAtExit;
        bool m_IsPlayerCaught;
        float m_Timer;
        bool m_HasAudioPlayed;

        private float m_Demo_GameTimer;
        private bool m_Demo_GameTimerIsTicking;

        void Start()
        {
            if (endScreen != null)
            {
                Color c = endScreen.color;
                c.a = 0f;
                endScreen.color = c;
            }

            if (caughtScreen != null)
            {
                Color c = caughtScreen.color;
                c.a = 0f;
                caughtScreen.color = c;
            }

            m_Demo_GameTimer = 0.0f;
            m_Demo_GameTimerIsTicking = true;
            Demo_UpdateTimerLabel();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == player)
            {
                m_IsPlayerAtExit = true;
            }
        }

        public void CaughtPlayer()
        {
            m_IsPlayerCaught = true;
        }

        void Update()
        {
            if (m_Demo_GameTimerIsTicking)
            {
                m_Demo_GameTimer += Time.deltaTime;
                Demo_UpdateTimerLabel();
            }

            if (m_IsPlayerAtExit)
            {
                EndLevel(endScreen, true, exitAudio);
            }
            else if (m_IsPlayerCaught)
            {
                EndLevel(caughtScreen, true, caughtAudio);
            }
        }

        void EndLevel(Image image, bool doRestart, AudioSource audioSource)
        {
            m_Demo_GameTimerIsTicking = false;

            if (!m_HasAudioPlayed)
            {
                if (audioSource != null)
                {
                    audioSource.Play();
                }
                m_HasAudioPlayed = true;
            }

            m_Timer += Time.deltaTime;

            if (image != null)
            {
                Color color = image.color;
                color.a = m_Timer / fadeDuration;
                image.color = color;
            }

            if (m_Timer > fadeDuration + displayImageDuration)
            {
                if (doRestart)
                {
                    SceneManager.LoadScene("DemoScene");
                }
                else
                {
                    Application.Quit();
                    Time.timeScale = 0;
                }
            }
        }

        void Demo_UpdateTimerLabel()
        {
            if (demoTimerText != null)
            {
                demoTimerText.text = m_Demo_GameTimer.ToString("0.00");
            }
        }
    }
}