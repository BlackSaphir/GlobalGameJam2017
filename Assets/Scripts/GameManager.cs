using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int money;
    public float PlayTime;
    public int Waves;
    Minion Minion;
    float Lane1Timer;
    float Lane2Timer;
    float Lane3Timer;
    float Lane4Timer;

    // Use this for initialization
    void Start()
    {
        Lane1Timer = 0;
        Lane2Timer = 0;
        Lane3Timer = 0;
        Lane4Timer = 0;

        PlayTime = 0.0f;
        Minion = gameObject.GetComponent<Minion>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayTime += Time.deltaTime;
        PlayTime = Mathf.Round(PlayTime * 100.0f) / 100.0f;
        if (Minion.alive == false)
        {
            money += Minion.money;
        }
    }

    void WaveSpawn()
    {
    }
}
