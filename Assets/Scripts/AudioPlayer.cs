using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    private PlayAudioOnCollision audioSource;
    public Slider progressBar;
    private bool isPlaying = false;

    public void SetAudioSource(PlayAudioOnCollision audioSource)
    {
        this.audioSource = audioSource;
        SetProgressBar(audioSource.getClipLength());
    }

    void Update()
    {
        if (audioSource.isPlaying)
        {
            progressBar.value = audioSource.getClipTime();
        }
    }
    
    public void SetProgressBar(float clipTime)
    {
        progressBar.minValue = 0;
        progressBar.maxValue = clipTime;
        progressBar.value = 0;
    }

    public void TogglePlay()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            isPlaying = false;
            Debug.Log("Pause");
        }
        else
        {
            audioSource.Play();
            isPlaying = true;
            Debug.Log("Play");
        }
    }
}
