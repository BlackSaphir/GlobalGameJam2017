using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public int Money;
    public Text displayMoney;

    // Use this for initialization
    void Start()
    {
        Money = 0;
        InvokeRepeating("getMoney", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getMoney()
    {
        Money += 20;
        displayMoney.text = "Gold " + Money.ToString();
    }
}
