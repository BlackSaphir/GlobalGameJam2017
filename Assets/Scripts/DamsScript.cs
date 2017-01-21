using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamsScript : MonoBehaviour
{
    float Health;
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Health -= 5;
        }
    }
}
