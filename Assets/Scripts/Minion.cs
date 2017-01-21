using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    public GameManager gameManager;
    public float speed;
    public float health;
    public int defense;
    public bool alive;
    public int money;
    public GameObject[] Waypoints;
    public int index = 0;
    public GameObject Lane;
    // Use this for initialization
    void Start()
    {
        health = 100;
        gameManager = FindObjectOfType<GameManager>();
        this.tag = "Enemy";
        alive = true;

        Waypoints = new GameObject[Lane.transform.childCount];

        for (int i = 0; i < Lane.transform.childCount; i++)
        {
            Waypoints[i] = Lane.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveTo();
        if (health <= 0)
        {
            alive = false;
            Destroy(this.gameObject);
        }
    }

    public void MoveTo()
    {
        if (transform.position == Waypoints[index].transform.position && index < Waypoints.Length - 1)
        {
            index++;
        }
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[index].transform.position, speed);
    }

}
