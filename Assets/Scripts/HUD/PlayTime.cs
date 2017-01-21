using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour
{
    private float playTime;
    public Text DisplayTime;


    // Use this for initialization
    void Start()
    {
        playTime = 0;
        InvokeRepeating("IncreaseTimer", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseTimer()
    {
        playTime += 1.0f;
        DisplayTime.text = "Time " + ((int)playTime).ToString();
    }
}
