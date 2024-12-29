using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GucBelirle : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gucText;
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
        gucText.text = sliderValue.ToString();
    }
}
