using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopTorbasi : MonoBehaviour
{
    public int id;

    public int moneyReward;
    public float extraGravity;
    private Rigidbody rb;
    [SerializeField] private AudioSource copToplamaAudioSource;
    [SerializeField] private AudioClip copToplamaSoundEffect;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.AddForce(Vector3.down * extraGravity, ForceMode.Force);
        moneyReward = 1 + CarSkillLevelManager.priceOfTrashLevel;
        copToplamaAudioSource.volume = 1;
        copToplamaAudioSource.volume *= PlayerPrefs.GetFloat("GeneralSound");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            if (other.GetComponent<ArabaCopDeposu>().copSayisi <
                other.GetComponent<ArabaCopDeposu>().azamiCopSayisi)
            {
                other.GetComponent<ArabaCopDeposu>().copSayisi++;
                copToplamaAudioSource.PlayOneShot(copToplamaSoundEffect);
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                gameObject.GetComponent<MeshCollider>().enabled = false;
                Destroy(gameObject, 0.7f);
            }
        }
        //if (other.tag == "Tekerlek")
        //{
        //    if (other.GetComponentInParent<ArabaCopDeposu>().copSayisi <
        //        other.GetComponentInParent<ArabaCopDeposu>().azamiCopSayisi)
        //    {
        //        other.GetComponentInParent<ArabaCopDeposu>().copSayisi++;
        //        Destroy(gameObject);
        //    }
        //}
        if (other.tag == "CopKutusu")
        {
            MoneyEventManager.EarnMoney(moneyReward);
            Destroy(gameObject);
        }
    }
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.tag == "Car")
    //    {
    //        if (other.GetComponent<ArabaCopDeposu>().copSayisi <
    //            other.GetComponent<ArabaCopDeposu>().azamiCopSayisi)
    //        {
    //            other.GetComponent<ArabaCopDeposu>().copSayisi++;
    //            Destroy(gameObject);
    //        }
    //    }
    //    if (other.tag == "Tekerlek")
    //    {
    //        if (other.GetComponentInParent<ArabaCopDeposu>().copSayisi <
    //            other.GetComponentInParent<ArabaCopDeposu>().azamiCopSayisi)
    //        {
    //            other.GetComponentInParent<ArabaCopDeposu>().copSayisi++;
    //            Destroy(gameObject);
    //        }
    //    }
    //}
}
