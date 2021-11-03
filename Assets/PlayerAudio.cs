using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{ 
    public AudioClip splashSound;
    public AudioSource audioS;
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("water"))
        {
            audioS.PlayOneShot(splashSound);
        }

         if (other.CompareTag("EST"))
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("water"))
        {
            audioS.PlayOneShot(splashSound);
        }
    }

