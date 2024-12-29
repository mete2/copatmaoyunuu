using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyEventManager : MonoBehaviour
{
    // Oyuncunun alt�n kazand���n� bildiren bir event
    public static Action<int> OnMoneyEarned;
    public static Action<int> OnMoneySpent;

    // Alt�n kazand�ran bir metot
    public static void EarnMoney(int amount)
    {
        OnMoneyEarned?.Invoke(amount);
    }
    // Alt�n harcayan bir metot
    public static void SpendMoney(int amount)
    {
        OnMoneySpent?.Invoke(amount);
    }
}
