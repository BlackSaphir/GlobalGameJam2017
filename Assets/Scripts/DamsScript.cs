using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamsScript : MonoBehaviour
{
    public float HealthTime = 100.0f;
    public bool damBroken;

    public Gif gif;

    void Start()
    {        
        damBroken = false;
    }

    // Update is called once per frame
    void Update()
    {
        HealthTime -= Time.deltaTime;
        if (HealthTime <= 0)
        {
            gif.kacke = false;
            Destroy(gameObject);
        }
    }    
}
