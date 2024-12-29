using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArabaCopDeposu : MonoBehaviour
{
    public int copSayisi;
    public int azamiCopSayisi;
    [SerializeField] private TextMeshProUGUI copSayisiText;
    // Start is called before the first frame update
    private void Awake()
    {
        PlayerPrefs.SetInt("CopTorbalari",0);
        copSayisi = PlayerPrefs.GetInt("CopTorbalari");
    }

    // Update is called once per frame
    void Update()
    {
        azamiCopSayisi = 5 + CarSkillLevelManager.depotLevel;
        PlayerPrefs.SetInt("CopTorbalari", copSayisi);
        copSayisiText.text = copSayisi.ToString() + "/" + azamiCopSayisi;
    }
}
