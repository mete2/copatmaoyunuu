using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUIManager : MonoBehaviour
{
    [SerializeField] GameObject shopMenuUI;
    [SerializeField] GameObject shopButton;

    public bool activeShop;
    public void Button_Shop()
    {
        activeShop = !activeShop;
    }
    private void Update()
    {
        if (shopButton.activeSelf)
        {
            if (activeShop)
                shopMenuUI.SetActive(true);
            else
                shopMenuUI.SetActive(false);
        }
        else
        {
            shopMenuUI.SetActive(shopButton.activeSelf);
        }
    }
}
