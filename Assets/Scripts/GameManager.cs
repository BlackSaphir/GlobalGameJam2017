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
    public GameObject MinionFish;
    public GameObject MinionTurtle;
    public GameObject MinionJellyFish;
    public GameObject MinionLaserShark;
    //public GameObject dam1;
    //public GameObject dam2;
    //public GameObject dam3;
    //public GameObject prefab1;
    //public GameObject prefab2;
    //public GameObject prefab3;


    public GameObject Lane;
    public float SpawnTimer;

    private GameObject MinionPre;
    public float waveTimer;
    float Lane1Timer;
    float Lane2Timer;
    float Lane3Timer;
    float Lane4Timer;

    public DamGridScript damGrid1;
    public DamGridScript damGrid2;
    public DamGridScript damGrid3;

    // Use this for initialization
    void Start()
    {
        Waves = 1;
        Lane = GameObject.Find("Lane1");
        MinionLane1Count = 0;
        MinionLane2Count = 0;
        MinionLane3Count = 0;
        MinionLane4Count = 0;
        WaveLength = 10;
        waveTimer = 0;
        Lane1Timer = 0;
        Lane2Timer = 0;
        Lane3Timer = 0;
        Lane4Timer = 0;
        MinionPre = MinionFish;
        PlayTime = 0.0f;
        //Minion = gameObject.GetComponent<Minion>();
        //SpawnMinion(MinionJellyFish, "Lane1");
    }

    // Update is called once per frame
    void Update()
    {
        //if (damGrid1.dam == null)
        //{
        //    WaveSpawnLane2();
        //    Lane2Timer += Time.deltaTime;
        //}

        //if (damGrid2.dam == null)
        //{
        //    WaveSpawnLane3();
        //    Lane3Timer += Time.deltaTime;
        //}

        //if (damGrid3.dam == null)
        //{
        //    WaveSpawnLane4();
        //    Lane4Timer += Time.deltaTime;
        //}

        //WaveSpawnLane1();


        SpawnMinion(MinionFish, "Lane1", 5 * Waves);

        if (Waves >= 4)
        {
            SpawnMinion(MinionJellyFish, "Lane2", 5 *( Waves - 4));
        }

        if (Waves >= 8)
        {
            SpawnMinion(MinionTurtle, "Lane4", 5 * (Waves - 8));
        }

        if (Waves >= 20)
        {
            SpawnMinion(MinionLaserShark, "Lane3", 5 * (Waves - 20));
        }




        Lane1Timer += Time.deltaTime;
        Lane2Timer += Time.deltaTime;

        PlayTime += Time.deltaTime;
        PlayTime = Mathf.Round(PlayTime * 100.0f) / 100.0f;
    }

    void SpawnMinion(GameObject minion, string lane, int amount)
    {
        Lane = GameObject.Find(lane);

        if (lane == "Lane1")
        {
            if (Lane1Timer > 1.5f && MinionLane1Count < amount)
            {
                GameObject temp = (GameObject)Instantiate(minion, Lane.transform.position, Lane.transform.rotation);
                temp.GetComponent<Minion>().Lane = GameObject.Find(lane);
                MinionLane1Count++;
                Lane1Timer = 0;
            }
        }

        if (lane == "Lane2")
        {
            if (Lane2Timer > 1.5f && MinionLane2Count < amount)
            {
                GameObject temp = (GameObject)Instantiate(minion, Lane.transform.position, Lane.transform.rotation);
                temp.GetComponent<Minion>().Lane = GameObject.Find(lane);
                MinionLane2Count++;
                Lane2Timer = 0;
            }
        }


        if (lane == "Lane3")
        {
            if (Lane3Timer > 1.5f && MinionLane3Count < amount)
            {
                GameObject temp = (GameObject)Instantiate(minion, Lane.transform.position, Lane.transform.rotation);
                temp.GetComponent<Minion>().Lane = GameObject.Find(lane);
                MinionLane3Count++;
                Lane3Timer = 0;
            }
        }
        if (lane == "Lane4")
        {
            if (Lane4Timer > 1.5f && MinionLane4Count < amount)
            {
                GameObject temp = (GameObject)Instantiate(minion, Lane.transform.position, Lane.transform.rotation);
                temp.GetComponent<Minion>().Lane = GameObject.Find(lane);
                MinionLane4Count++;
                Lane4Timer = 0;
            }
        }

        if (MinionLane1Count >= 5 * Waves)
        {
            waveTimer += Time.deltaTime;
            if (waveTimer >= 10f)
            {
                Waves++;
                MinionLane1Count = 0;
                waveTimer = 0f;
            }
        }
    }


}
