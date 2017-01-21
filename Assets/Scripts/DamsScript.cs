using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamsScript : MonoBehaviour
{
    public float HealthTime = 100;
    public bool damBroken;

    void Start()
    {
        damBroken = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthTime <= 0)
        {
            Destroy(this.gameObject);
            damBroken = true;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            HealthTime -= 5;
        }
    }
}
