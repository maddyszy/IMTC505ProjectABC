using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip treeAudio;
    private AudioSource audioSource;
    public Slider progressBar;
    private bool isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = treeAudio;

        progressBar.minValue = 0;
        progressBar.maxValue = treeAudio.length;
        progressBar.value = 0;
    }

    void Update()
    {
        if (isPlaying && audioSource.isPlaying)
        {
            progressBar.value = audioSource.time;
        }
    }

    public void TogglePlay()
    {
        if (isPlaying)
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
