using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour
{
    public float Health;
    public GameObject MenuObject;

    // Use this for initialization
    void Start()
    {
        MenuObject.SetActive(false);
        Health = 100;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            MenuObject.SetActive(true);
            Time.timeScale = 0;
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Health -= 10;
        }
    }
}
