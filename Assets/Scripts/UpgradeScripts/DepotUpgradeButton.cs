using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DepotUpgradeButton : MonoBehaviour
{
    [SerializeField] private int priceOfUpgrade;
    [SerializeField] TextMeshProUGUI textOfPriceOfUpgrade;
    [SerializeField] TextMeshProUGUI textOfDepotLevel;
    private void Start()
    {
        textOfDepotLevel.text = CarSkillLevelManager.depotLevel.ToString() + "/20";
        textOfPriceOfUpgrade.text = priceOfUpgrade.ToString() + "$";
    }

    private void Update()
    {
        if (CarSkillLevelManager.depotLevel == 0)
        {
            priceOfUpgrade = 10;
        }
        else if(CarSkillLevelManager.depotLevel == 1)
        {
            priceOfUpgrade = 20;
        }
        else if (CarSkillLevelManager.depotLevel == 2)
        {
            priceOfUpgrade = 50;
        }
        else if (CarSkillLevelManager.depotLevel == 3)
        {
            priceOfUpgrade = 100;
        }
        else if (CarSkillLevelManager.depotLevel == 4)
        {
            priceOfUpgrade = 150;
        }
        else if (CarSkillLevelManager.depotLevel == 5)
        {
            priceOfUpgrade = 250;
        }
        else if (CarSkillLevelManager.depotLevel == 6)
        {
            priceOfUpgrade = 350;
        }
        else if (CarSkillLevelManager.depotLevel == 7)
        {
            priceOfUpgrade = 500;
        }
        else if (CarSkillLevelManager.depotLevel == 8)
        {
            priceOfUpgrade = 650;
        }
        else if (CarSkillLevelManager.depotLevel == 9)
        {
            priceOfUpgrade = 800;
        }
        else if (CarSkillLevelManager.depotLevel == 10)
        {
            priceOfUpgrade = 1000;
        }
        else if (CarSkillLevelManager.depotLevel == 11)
        {
            priceOfUpgrade = 1250;
        }
        else if (CarSkillLevelManager.depotLevel == 12)
        {
            priceOfUpgrade = 1500;
        }
        else if (CarSkillLevelManager.depotLevel == 13)
        {
            priceOfUpgrade = 2000;
        }
        else if (CarSkillLevelManager.depotLevel == 14)
        {
            priceOfUpgrade = 2500;
        }
        else if (CarSkillLevelManager.depotLevel == 15)
        {
            priceOfUpgrade = 3000;
        }
        else if (CarSkillLevelManager.depotLevel == 16)
        {
            priceOfUpgrade = 4000;
        }
        else if (CarSkillLevelManager.depotLevel == 17)
        {
            priceOfUpgrade = 5000;
        }
        else if (CarSkillLevelManager.depotLevel == 18)
        {
            priceOfUpgrade = 7500;
        }
        else if (CarSkillLevelManager.depotLevel == 19)
        {
            priceOfUpgrade = 10000;
        }
        if (CarSkillLevelManager.depotLevel == 20)
        {
            textOfPriceOfUpgrade.text = "MAX";
        }
        else
        {
            textOfPriceOfUpgrade.text = priceOfUpgrade.ToString() + "$";
        }
        
        if(CarSkillLevelManager.depotLevel == 19)
        {
            textOfPriceOfUpgrade.fontSize = 60;
        }
        else if (CarSkillLevelManager.depotLevel >= 10)
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
        if (CarSkillLevelManager.depotLevel < 20)
        {
            if ((CarMoneyManager.playerMoney - priceOfUpgrade) >= 0)
            {
                SkillUpgradeEventManager.UpgradeDepotSkill();
                MoneyEventManager.SpendMoney(priceOfUpgrade);
            }
            else
            {
                print("Para yetmiyor. Skill Upgrade edilemedi.");
            }
        }
        textOfDepotLevel.text = CarSkillLevelManager.depotLevel.ToString() + "/20";
    }
}
