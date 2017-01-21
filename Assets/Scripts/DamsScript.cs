using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamsScript : MonoBehaviour
{
    float HealthTime;
    void Start()
    {;
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthTime <= 0)
        {
            Destroy(this.gameObject);
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
