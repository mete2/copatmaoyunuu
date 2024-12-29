using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpeedUpgradeButton : MonoBehaviour
{
    [SerializeField] private int priceOfUpgrade;
    [SerializeField] TextMeshProUGUI textOfSpeedLevel;
    [SerializeField] TextMeshProUGUI textOfPriceOfUpgrade;
    private void Start()
    {
        textOfSpeedLevel.text = CarSkillLevelManager.speedLevel.ToString() + "/10";
        textOfPriceOfUpgrade.text = priceOfUpgrade.ToString() + "$";
    }
    private void Update()
    {
        switch (CarSkillLevelManager.speedLevel)
        {
            case 1: priceOfUpgrade = 25;
                break;
            case 2: priceOfUpgrade = 50;
                break;
            case 3: priceOfUpgrade = 100;
                break;
            case 4: priceOfUpgrade = 150;
                break;
            case 5: priceOfUpgrade = 250;
                break;
            case 6: priceOfUpgrade = 500;
                break;
            case 7: priceOfUpgrade = 750;
                break;
            case 8: priceOfUpgrade = 1000;
                break;
            case 9: priceOfUpgrade = 1500;
                break;
            default:
                break;
        }
        if (CarSkillLevelManager.speedLevel == 10)
        {
            textOfPriceOfUpgrade.text = "MAX";
        }
        else
        {
            textOfPriceOfUpgrade.text = priceOfUpgrade.ToString() + "$";
        }

        if (CarSkillLevelManager.speedLevel > 7)
        {
            textOfPriceOfUpgrade.fontSize = 80;
        }
        else
        {
            textOfPriceOfUpgrade.fontSize = 100;
        }
    }
    public void UpgradeLevel()
    {
        if (CarSkillLevelManager.speedLevel < 10)
        {
            if ((CarMoneyManager.playerMoney - priceOfUpgrade) >= 0)
            {
                SkillUpgradeEventManager.UpgradeSpeedSkill();
                MoneyEventManager.SpendMoney(priceOfUpgrade);
            }
            else
            {
                print("Para yetmiyor. Skill Upgrade edilemedi.");
            }
        }
        textOfSpeedLevel.text = CarSkillLevelManager.speedLevel.ToString() + "/10";
    }
}
