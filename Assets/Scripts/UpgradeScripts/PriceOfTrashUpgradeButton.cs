using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PriceOfTrashUpgradeButton : MonoBehaviour
{
    [SerializeField] private int priceOfUpgrade;
    [SerializeField] TextMeshProUGUI textOfPriceOfTrashLevel;
    [SerializeField] TextMeshProUGUI textOfPriceOfUpgrade;
    private void Start()
    {
        textOfPriceOfUpgrade.text = CarSkillLevelManager.priceOfTrashLevel.ToString();
        textOfPriceOfTrashLevel.text = CarSkillLevelManager.priceOfTrashLevel.ToString() + "/20";
    }
    private void Update()
    {
        if (CarSkillLevelManager.priceOfTrashLevel == 0)
        {
            priceOfUpgrade = 10;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 1)
        {
            priceOfUpgrade = 20;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 2)
        {
            priceOfUpgrade = 50;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 3)
        {
            priceOfUpgrade = 100;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 4)
        {
            priceOfUpgrade = 150;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 5)
        {
            priceOfUpgrade = 250;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 6)
        {
            priceOfUpgrade = 350;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 7)
        {
            priceOfUpgrade = 500;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 8)
        {
            priceOfUpgrade = 650;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 9)
        {
            priceOfUpgrade = 800;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 10)
        {
            priceOfUpgrade = 1000;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 11)
        {
            priceOfUpgrade = 1250;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 12)
        {
            priceOfUpgrade = 1500;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 13)
        {
            priceOfUpgrade = 2000;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 14)
        {
            priceOfUpgrade = 2500;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 15)
        {
            priceOfUpgrade = 3000;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 16)
        {
            priceOfUpgrade = 4000;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 17)
        {
            priceOfUpgrade = 5000;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 18)
        {
            priceOfUpgrade = 7500;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel == 19)
        {
            priceOfUpgrade = 10000;
        }
        if (CarSkillLevelManager.priceOfTrashLevel == 20)
        {
            textOfPriceOfUpgrade.text = "MAX";
        }
        else
        {
            textOfPriceOfUpgrade.text = priceOfUpgrade.ToString() + "$";
        }

        if (CarSkillLevelManager.priceOfTrashLevel == 19)
        {
            textOfPriceOfUpgrade.fontSize = 60;
        }
        else if (CarSkillLevelManager.priceOfTrashLevel >= 10)
        {
            textOfPriceOfUpgrade.fontSize = 80;
        }
        else
        {
            textOfPriceOfUpgrade.fontSize = 100;
        }
        textOfPriceOfTrashLevel.text = CarSkillLevelManager.priceOfTrashLevel.ToString() + "/20";
    }
    public void UpgradeLevel()
    {
        if (CarSkillLevelManager.priceOfTrashLevel < 20)
        {
            if ((CarMoneyManager.playerMoney - priceOfUpgrade) >= 0)
            {
                SkillUpgradeEventManager.UpgradePriceOfTrashSkill();
                MoneyEventManager.SpendMoney(priceOfUpgrade);
            }
            else
            {
                print("Para yetmiyor. Skill Upgrade edilemedi.");
            }
        }
        textOfPriceOfTrashLevel.text = CarSkillLevelManager.priceOfTrashLevel.ToString() + "/20";
    }
}
