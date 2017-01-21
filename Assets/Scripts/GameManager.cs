using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int MinionLane1Count;
    public int MinionLane2Count;
    public int MinionLane3Count;
    public int MinionLane4Count;

    public int money;
    public float PlayTime;
    public int Waves;
    public int WaveLength;
    public Minion Minion;
    private GameObject MinionPre;
    public GameObject MinionFish;
    public GameObject MinionTurtle;
    public GameObject MinionJellyFish;
    public GameObject MinionLaserShark;
    
    public GameObject Lane;
    public float SpawnTimer;

    float Lane1Timer;
    float Lane2Timer;
    float Lane3Timer;
    float Lane4Timer;

    // Use this for initialization
    void Start()
    {
        Lane = GameObject.Find("Lane1");
        MinionLane1Count = 0;
        MinionLane2Count = 0;
        MinionLane3Count = 0;
        MinionLane4Count = 0;
        WaveLength = 10;
        Lane1Timer = 0;
        Lane2Timer = 0;
        Lane3Timer = 0;
        Lane4Timer = 0;
        MinionPre = MinionFish;
        PlayTime = 0.0f;
        Minion = gameObject.GetComponent<Minion>();
    }

    // Update is called once per frame
    void Update()
    {
        WaveSpawnLane1();
        //WaveSpawnLane2();
        //WaveSpawnLane3();
        //WaveSpawnLane4();
        Lane1Timer += Time.deltaTime;
        Lane2Timer += Time.deltaTime;
        Lane3Timer += Time.deltaTime;
        Lane4Timer += Time.deltaTime;
        
        PlayTime += Time.deltaTime;
        PlayTime = Mathf.Round(PlayTime * 100.0f) / 100.0f;

        if (PlayTime > 40.0f)
        {
            WaveSpawnLane2();
        }

        if (PlayTime > 90.0f)
        {
            WaveSpawnLane3();
        }

        if (PlayTime > 150.0f)
        {
            WaveSpawnLane4();
        }
    }

    void WaveSpawnLane1()
    {
        MinionPre = MinionFish;
        Lane = GameObject.Find("Lane1");        
        if (Lane1Timer > 1.5f && MinionLane1Count < WaveLength)
        {
            GameObject temp = (GameObject)Instantiate(MinionPre, Lane.transform.position, Lane.transform.rotation);
            temp.GetComponent<Minion>().Lane = GameObject.Find("Lane1");
            MinionLane1Count++;
            Lane1Timer = 0;
        }
    }

    void WaveSpawnLane2()
    {
        MinionPre = MinionTurtle;
        Lane = GameObject.Find("Lane2");        
        if (Lane2Timer > 2.0f && MinionLane2Count < WaveLength)
        {
            GameObject temp = (GameObject)Instantiate(MinionPre, Lane.transform.position, Lane.transform.rotation);
            temp.GetComponent<Minion>().Lane = GameObject.Find("Lane2");
            MinionLane2Count++;
            Lane2Timer = 0;            
        }
    }

    void WaveSpawnLane3()
    {
        MinionPre = MinionJellyFish;
        Lane = GameObject.Find("Lane3");
        if (Lane3Timer > 1.5f && MinionLane3Count < WaveLength)
        {
            GameObject temp = (GameObject)Instantiate(MinionPre, Lane.transform.position, Lane.transform.rotation);
            temp.GetComponent<Minion>().Lane = GameObject.Find("Lane3");
            MinionLane3Count++;
            Lane3Timer = 0;
        }
    }

    void WaveSpawnLane4()
    {
        MinionPre = MinionLaserShark;
        Lane = GameObject.Find("Lane4");
        if (Lane4Timer > 1.5f && MinionLane4Count < WaveLength)
        {
            GameObject temp = (GameObject)Instantiate(MinionPre, Lane.transform.position, Lane.transform.rotation);
            temp.GetComponent<Minion>().Lane = GameObject.Find("Lane4");
            MinionLane4Count++;
            Lane4Timer = 0;
        }
    }


}
