using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasStation : MonoBehaviour
{
    [SerializeField] GameObject shopButton;
    [SerializeField] GameObject locationSavedText;
    public Transform parentTransform;
    public int id;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Car")
        {
            shopButton.SetActive(true);
            if (PlayerPrefs.GetInt("SpawnPoint") != id)
            {
                PlayerPrefs.SetInt("SpawnPoint", id);
                GameObject newUIElement = Instantiate(locationSavedText, parentTransform);
                Destroy(newUIElement, 5);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Car")
        {
            shopButton.SetActive(false);
        }
    }
}
