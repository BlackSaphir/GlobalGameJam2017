using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    public int speed;
    public float life;
    public int defense;
    public bool alive;
    public int money;
    public GameObject[] Waypoints;
    public int index = 0;
    // Use this for initialization
    void Start()
    {
        this.tag = "Enemy";
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTo();
        if (life<=0)
        {
            alive = false;
            Destroy(this);
        }

    }

    public void MoveTo()
    {
        if (transform.position == Waypoints[index].transform.position && index < Waypoints.Length - 1)
        {
            index++;
        }
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[index].transform.position,1f);
    }
}
