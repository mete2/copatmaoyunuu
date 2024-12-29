using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    [SerializeField] GameObject menuUI;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("IsFirstTime", 0) == 0)
        {
            menuUI.SetActive(true);
            PlayerPrefs.SetInt("IsFirstTime", 1);
        }
    }
    public void Button_OptionsMenu()
    {
        menuUI.SetActive(!menuUI.activeSelf);
    }
}
