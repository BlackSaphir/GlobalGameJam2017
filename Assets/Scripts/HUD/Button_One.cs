using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_One : MonoBehaviour
{
    public Button ButtonOne;
    GameManager BuyMoney;

    public int Cost;

    // Use this for initialization
    void Start()
    {
        BuyMoney = GameObject.FindObjectOfType<GameManager>();
 
     
    }

    // Update is called once per frame
    void Update()
    {
        ClickButton();        
    }

    public void ClickButton()
    {
        if (BuyMoney.money >= Cost)
        {
            ButtonOne.interactable = true;
        }
        else
        {
            ButtonOne.interactable = false;
        }
    }

}
