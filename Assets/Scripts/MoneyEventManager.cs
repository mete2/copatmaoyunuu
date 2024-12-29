using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyEventManager : MonoBehaviour
{
    // Oyuncunun altýn kazandýðýný bildiren bir event
    public static Action<int> OnMoneyEarned;
    public static Action<int> OnMoneySpent;

    // Altýn kazandýran bir metot
    public static void EarnMoney(int amount)
    {
        OnMoneyEarned?.Invoke(amount);
    }
    // Altýn harcayan bir metot
    public static void SpendMoney(int amount)
    {
        OnMoneySpent?.Invoke(amount);
    }
}
