using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] Slider generalSoundSlider;

    [SerializeField] Slider musicSoundSlider;
    [SerializeField] TextMeshProUGUI musicIndexText;
    public int musicSoundIndex;

    [SerializeField] Toggle toggleEngineSound;
    [SerializeField] Toggle toggleHumans;
    [Header("Buttons")]
    [SerializeField] GameObject buttons;

    [Header("Menu")]
    [SerializeField] GameObject optionsMenu;

    void Awake()
    {
        if (PlayerPrefs.GetInt("IsFirstTime", 0) == 0)
        {
            buttons.SetActive(false);
            optionsMenu.SetActive(true);
        }
        if (PlayerPrefs.GetInt("CarEngineSound", 1) == 1)
            toggleEngineSound.isOn = true;
        else
            toggleEngineSound.isOn = false;

        if (PlayerPrefs.GetInt("Humans", 1) == 1)
            toggleHumans.isOn = true;
        else
            toggleHumans.isOn = false;
        generalSoundSlider.value = PlayerPrefs.GetFloat("GeneralSound",1);
        musicSoundSlider.value = PlayerPrefs.GetFloat("MusicSound",1);
    }
    private void Update()
    {
        if (toggleEngineSound.isOn == true)
        {
            PlayerPrefs.SetInt("CarEngineSound", 1);
        }
        else
        {
            PlayerPrefs.SetInt("CarEngineSound", 0);
        }
        if (toggleHumans.isOn == true)
        {
            PlayerPrefs.SetInt("Humans", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Humans", 0);
        }
        PlayerPrefs.SetFloat("GeneralSound", generalSoundSlider.value);
        PlayerPrefs.SetFloat("MusicSound", musicSoundSlider.value);
        musicSoundIndex = Mathf.Clamp(musicSoundIndex, 0, 3);
        PlayerPrefs.SetInt("Music", musicSoundIndex);
        musicIndexText.text = (musicSoundIndex + 1).ToString();
        
        if(optionsMenu.activeSelf == true)
            buttons.SetActive(false);
        if (buttons.activeSelf == true)
            optionsMenu.SetActive(false);
    }

    //Button resume sonra halledicem
    public void Button_Options()
    {
        optionsMenu.SetActive(true);
        buttons.SetActive(false);
    }
    public void Button_Back()
    {
        optionsMenu.SetActive(false);
        buttons.SetActive(true);
    }
    public void Button_Quit()
    {
        Application.Quit();
    }

    public void Button_SonrakiMuzik()
    {
        musicSoundIndex++;
    }
    public void Button_OncekiMuzik()
    {
        musicSoundIndex--;
    }
}
