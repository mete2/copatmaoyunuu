using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSkillLevelManager : MonoBehaviour
{
    public static float speedLevel;
    public static int depotLevel;
    public static int priceOfTrashLevel;

    private void Awake()
    {
        speedLevel = PlayerPrefs.GetFloat("SpeedLevel");
        depotLevel = PlayerPrefs.GetInt("DepotLevel");
        priceOfTrashLevel = PlayerPrefs.GetInt("PriceOfTrashLevel");
        if (PlayerPrefs.GetInt("SpeedLevel") >= 20)
        {
            SkillUpgradeEventManager.OnUpgradeSpeedEvent -= UpgradeSpeedSkill;
        }
        else
        {
            SkillUpgradeEventManager.OnUpgradeSpeedEvent += UpgradeSpeedSkill;
        }
        if (PlayerPrefs.GetInt("DepotLevel") >= 20)
        {
            SkillUpgradeEventManager.OnUpgradeDepotEvent -= UpgradeDepotSkill;
            print("DepotLevel 20");
        }
        else
        {
            SkillUpgradeEventManager.OnUpgradeDepotEvent += UpgradeDepotSkill;
            print("DepotLevel 20 den az");
        }
        if (PlayerPrefs.GetInt("PriceOfTrashLevel") >= 20)
        {
            SkillUpgradeEventManager.OnUpgradePriceEvent -= UpgradePriceSkill;
        }
        else
        {
            SkillUpgradeEventManager.OnUpgradePriceEvent += UpgradePriceSkill;
        }
    }

    void UpgradeSpeedSkill()
    {
        if (speedLevel < 10)
        {
            speedLevel += 1;
        }
        PlayerPrefs.SetFloat("SpeedLevel", speedLevel);
    }
    void UpgradeDepotSkill()
    {
        if (depotLevel < 20)
        {
            depotLevel += 1;
        }
        PlayerPrefs.SetInt("DepotLevel", depotLevel);
    }
    void UpgradePriceSkill()
    {
        if (priceOfTrashLevel < 20)
        {
            priceOfTrashLevel += 1;
        }
        PlayerPrefs.SetInt("PriceOfTrashLevel", priceOfTrashLevel);
    }
}
