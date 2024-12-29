using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    [SerializeField] AudioClip[] musics;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = 1;
        audioSource.clip = musics[PlayerPrefs.GetInt("Music")];
        audioSource.volume *= PlayerPrefs.GetFloat("MusicSound");
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
