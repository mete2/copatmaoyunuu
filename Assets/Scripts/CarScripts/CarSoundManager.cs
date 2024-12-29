using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource carEngineAudioSource;
    private ArabaKontrolu arabaKontrolu;
    // Start is called before the first frame update
    void Start()
    {
        arabaKontrolu = GetComponent<ArabaKontrolu>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("CarEngineSound") == 1)
        {
            carEngineAudioSource.enabled = true;
        }
        else
        {
            carEngineAudioSource.enabled = false;
        }
        carEngineAudioSource.volume = Mathf.Clamp(Mathf.Abs(arabaKontrolu.rb.velocity.x / 9), 0.2f, 0.7f);
        carEngineAudioSource.volume *= PlayerPrefs.GetFloat("GeneralSound");
        if (!carEngineAudioSource.isPlaying)
        {
            carEngineAudioSource.Play();
        }
        carEngineAudioSource.pitch = Mathf.Clamp((Mathf.Abs(arabaKontrolu.rb.velocity.x) / (Mathf.Abs(arabaKontrolu.rb.velocity.x) + 1))* 1.35f, 0.8f, 1.5f);
    }
}
