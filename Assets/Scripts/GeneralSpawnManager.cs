using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSpawnManager : MonoBehaviour
{
    [SerializeField] GameObject characterSpawner;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Humans") == 1)
        {
            characterSpawner.SetActive(true);
        }
        else
        {
            characterSpawner.SetActive(false);
        }
    }
}
