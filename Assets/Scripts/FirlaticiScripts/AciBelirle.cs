using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AciBelirle : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI aciText;
    [SerializeField] public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        int sliderValue = (int)slider.value;
        aciText.text = sliderValue.ToString();
    }
}
