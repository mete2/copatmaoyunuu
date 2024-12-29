using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillUpgradeEventManager : MonoBehaviour
{
    public static Action OnUpgradeSpeedEvent;
    public static Action OnUpgradeDepotEvent;
    public static Action OnUpgradePriceEvent;

    public static void UpgradeSpeedSkill()
    {
        OnUpgradeSpeedEvent?.Invoke();
    }
    public static void UpgradeDepotSkill()
    {
        OnUpgradeDepotEvent?.Invoke();
    }
    public static void UpgradePriceOfTrashSkill()
    {
        OnUpgradePriceEvent?.Invoke();
    }
}