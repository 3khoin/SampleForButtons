using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    public GameObject shopUI;
    public bool shopActive;

    private void Start()
    {
        shopUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown("i"))
        {
            if(shopActive)
            {
                Debug.Log("Hiding shop");
                HideShop();
            }
            else
            {
                Debug.Log("Showing shop");
                ShowShop();
            }
        }
    }

    public void ShowShop()
    {
        shopUI.SetActive(true);
        shopActive = true;
    }

    public void HideShop()
    {
        shopUI.SetActive(false);
        shopActive = false;
    }
}