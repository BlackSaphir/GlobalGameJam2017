using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_One : MonoBehaviour
{
    public Button ButtonOne;
    Gold BuyMoney;

    // Use this for initialization
    void Start()
    {
        BuyMoney = GameObject.Find("Gold").GetComponent<Gold>();
    }

    // Update is called once per frame
    void Update()
    {
        ClickButton();        
    }

    public void ClickButton()
    {
        if (BuyMoney.Money >= 100)
        {
            ButtonOne.interactable = true;
        }
        else
        {
            ButtonOne.interactable = false;
        }
    }

}
