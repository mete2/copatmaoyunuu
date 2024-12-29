using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fırlatıcı : MonoBehaviour
{
    [SerializeField] private AciBelirle aciBelirle;
    [SerializeField] private GucBelirle gucBelirle;
    [SerializeField] private Transform topBaslangicTransform;
    [SerializeField] private GameObject copTorbasi;
    [SerializeField] private AudioSource copFirlatmaAudioSource;
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y,-aciBelirle.slider.value);
        copFirlatmaAudioSource.volume = 1;
        copFirlatmaAudioSource.volume *= PlayerPrefs.GetFloat("GeneralSound");
    }

    public void Button_AtesEtme()
    {
        if (GetComponentInParent<ArabaCopDeposu>().copSayisi > 0)
        {
            //ses efekti
            copFirlatmaAudioSource.Play();
            //eksilme işlemi
            GetComponentInParent<ArabaCopDeposu>().copSayisi--;
            //oluşturma işlemi
            GameObject a = Instantiate(copTorbasi, topBaslangicTransform.position, transform.rotation);
            //oluşturulan çöpu fırlatma işlemi
            a.GetComponent<Rigidbody>().AddForce(transform.up * gucBelirle.slider.value / 2.5f, ForceMode.Impulse);
        }
    }
}
