using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarmSound : MonoBehaviour
{
   public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
            else
            {
                Debug.LogError("Audio source is not assigned!");
            }


        }
        
    }
}
