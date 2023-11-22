using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip audioForCrabApple;
    public AudioClip audioForWhiteOak;
    public AudioClip audioForBlackCottonWood;
    public AudioClip audioForNorthernRedOak;
    public AudioClip audioForPinOak;
    public AudioClip audioForRedMaple1;
    public AudioClip audioForRedMaple2;
    public AudioClip audioForRedOak;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "MainCamera" tag
        if (other.CompareTag("MainCamera"))
        {
            // Check the tag of the GameObject with this script
            if (gameObject.CompareTag("CrabApple"))
            {
                PlayAudio(audioForCrabApple);
            }
            else if (gameObject.CompareTag("WhiteOak"))
            {
                PlayAudio(audioForWhiteOak);
            }
            else if (gameObject.CompareTag("BlackCottonWood"))
            {
                PlayAudio(audioForBlackCottonWood);
            }
            else if (gameObject.CompareTag("NorthernRedOak"))
            {
                PlayAudio(audioForNorthernRedOak);
            }
            else if (gameObject.CompareTag("PinOak"))
            {
                PlayAudio(audioForPinOak);
            }
            else if (gameObject.CompareTag("RedMaple1"))
            {
                PlayAudio(audioForRedMaple1);
            }
            else if (gameObject.CompareTag("RedMaple2"))
            {
                PlayAudio(audioForRedMaple2);
            }
            else if (gameObject.CompareTag("RedOak"))
            {
                PlayAudio(audioForRedOak);
            }
            // You can add more conditions for additional tags as needed
        }
    }

    private void PlayAudio(AudioClip audioClip)
    {
        if (audioClip != null)
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
        }
    }
}
