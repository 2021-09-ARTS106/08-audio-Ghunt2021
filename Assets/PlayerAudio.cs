using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("water"))
        {
            audioS.PlayOneShot(splashSound);
        }
    }

