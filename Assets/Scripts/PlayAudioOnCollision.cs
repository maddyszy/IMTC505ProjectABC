using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    private static AudioSource currentAudioSource;
    private AudioSource audioSource;

    private void Awake()
    {
        string treeTag = gameObject.tag;
        string audioFilePath = "Audio/" + treeTag;
        AudioClip audioClip = Resources.Load<AudioClip>(audioFilePath);
        if (audioClip != null)
        {
            audioSource = gameObject.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.clip = audioClip;
            }
            else
            {
                Debug.LogError("AudioSource not found for: " + treeTag);
            }
        }
        else
        {
            Debug.LogError("Audio file not found for: " + treeTag);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has a specific tag (optional)
        if (other.CompareTag("MainCamera"))
        {
            Play();
        }
    }

    public float getClipLength()
    {
        return audioSource.clip.length;
    }

    public float getClipTime()
    {
        return audioSource.time;
    }

    public bool isPlaying
    {
        get
        {
            return audioSource.isPlaying;
        }
    }

    public void Play()
    {
        if (currentAudioSource != null && currentAudioSource.isPlaying)
        {
            currentAudioSource.Stop();
            Debug.Log("Current audio stopped.");
        }
        // Perform actions or behavior when the trigger event occurs
        audioSource.Play();
        Debug.Log("Audio playing:" + gameObject.tag);
        currentAudioSource = audioSource;
        // You can access the GameObject or components of the colliding object if needed
        // Example: other.gameObject.GetComponent<YourComponent>().YourMethod();
    }

    public void Pause()
    {
        audioSource.Pause();
    }
}
