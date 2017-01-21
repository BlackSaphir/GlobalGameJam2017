using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NextWave : MonoBehaviour
{
    private int waveCounter;
    public Text DisplayWave;

    // Use this for initialization
    void Start()
    {
        waveCounter = 0;
        InvokeRepeating("WaveCounter", 0.0f, 45.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WaveCounter()
    {
        waveCounter += 1;
        DisplayWave.text = "Wave " + waveCounter.ToString();
    }
}
