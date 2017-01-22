using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public int Money;
    public Text displayMoney;
    public GameManager GMMoney;

    // Use this for initialization
    void Start()
    {
       
        GMMoney.money = 100;
        InvokeRepeating("getMoney", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getMoney()
    {
        GMMoney.money += 5;
        displayMoney.text = "Gold " + GMMoney.money.ToString();
    }
}
