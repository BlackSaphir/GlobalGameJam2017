using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_One : MonoBehaviour
{
    bool clickable;
    public Button ButtonOne;


    // Use this for initialization
    void Start()
    {
        clickable = false;
    }

    // Update is called once per frame
    void Update()
    {
        ClickButton();
    }

    public void ClickButton()
    {
        if (GameObject.Find("Gold").GetComponent<Gold>().Money >= 100 && ButtonOne.interactable == false)
        {
            ButtonOne.interactable = true;
        }
        else
        {
            ButtonOne.interactable = false;
        }
    }
}
