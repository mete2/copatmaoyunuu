using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ÇöpKutusuSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource copGirmeAudioSource;
    private void Update()
    {
        copGirmeAudioSource.volume = 1;
        copGirmeAudioSource.volume *= PlayerPrefs.GetFloat("GeneralSound");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CopTorbasi")
        {
            copGirmeAudioSource.Play();
        }
    }
}
