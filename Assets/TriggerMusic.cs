using UnityEngine;

public class TriggerMusic : MonoBehaviour
{
    public AudioSource musicPlayer1;
    public AudioSource musicPlayer2;
    private bool isPaused = false;

    private void Start()
    {
        if (!musicPlayer1.isPlaying)
        {
            musicPlayer1.Play();
        }

        if (musicPlayer2.isPlaying)
        {
            musicPlayer2.Stop();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                if (!musicPlayer1.isPlaying && !musicPlayer2.isPlaying)
                {
                    if (musicPlayer1.time > 0 && musicPlayer1.time < musicPlayer1.clip.length)
                    {
                        musicPlayer1.Play();
                    }
                    if (musicPlayer2.time > 0 && musicPlayer2.time < musicPlayer2.clip.length)
                    {
                        musicPlayer2.Play();
                    }
                }
                isPaused = false;
            }
            else
            {
                if (musicPlayer1.isPlaying)
                {
                    musicPlayer1.Pause();
                }
                if (musicPlayer2.isPlaying)
                {
                    musicPlayer2.Pause();
                }
                isPaused = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (musicPlayer1.isPlaying)
            {
                musicPlayer1.Stop();
            }
            if (!musicPlayer2.isPlaying)
            {
                musicPlayer2.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (musicPlayer2.isPlaying)
            {
                musicPlayer2.Stop();
            }
            if (!musicPlayer1.isPlaying)
            {
                musicPlayer1.Play();
            }
        }
    }
}
