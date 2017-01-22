using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMovement : MonoBehaviour
{
    public GameObject[] Waypoints;
    public int index = 0;
    public float speed;
    public bool brokenDam;
    private SpriteRenderer spriterenderer;
    // Use this for initialization
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        spriterenderer.enabled = false;
        brokenDam = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (brokenDam == true)
        {
            spriterenderer.enabled = true;
            MoveTo();
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
