using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] GameObject tutorialImage;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("IsFirstTime",0) == 0)
        {
            tutorialImage.SetActive(true);
            PlayerPrefs.SetInt("IsFirstTime", 1);
        }
        else
        {
            tutorialImage.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Button_Close()
    {
        tutorialImage.SetActive(false);
    }
}
