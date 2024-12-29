using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarMoneyManager : MonoBehaviour
{
    public static int playerMoney; // Oyuncunun toplam alt�n miktar�
    public TextMeshProUGUI moneyAmount;
    [SerializeField] AudioSource paraHarcamaAudioSource;
    [SerializeField] AudioClip paraHarcamaAudioClip;
    private void Awake()
    {
        MoneyEventManager.OnMoneyEarned += AddGold;
        MoneyEventManager.OnMoneySpent += RemoveGold;
        FallingCollider.OnCarRespawn += RemoveGoldForRespawn;
        playerMoney = PlayerPrefs.GetInt("PlayerMoney");
    }
    private void Update()
    {
        moneyAmount.text = playerMoney.ToString();
        paraHarcamaAudioSource.volume = 1;
        paraHarcamaAudioSource.volume *= PlayerPrefs.GetFloat("GeneralSound");
    }
    void AddGold(int amount)
    {
        // Oyuncunun alt�n miktar�n� art�r
        playerMoney += amount;
        PlayerPrefs.SetInt("PlayerMoney", playerMoney);
    }
    void RemoveGold(int amount)
    {
        // Oyuncunun alt�n miktar�n� azalt
        paraHarcamaAudioSource.PlayOneShot(paraHarcamaAudioClip);
        playerMoney -= amount;
        PlayerPrefs.SetInt("PlayerMoney", playerMoney);
    }
    void RemoveGoldForRespawn()
    {
        playerMoney -= 50;
    }
}
