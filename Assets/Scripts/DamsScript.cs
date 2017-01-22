using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamsScript : MonoBehaviour
{
    public float HealthTime = 100.0f;
    public bool damBroken;
    public GameManager gm;
    public int waves;
    public Gif gif;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        damBroken = false;
    }

    // Update is called once per frame
    void Update()
    {
        HealthTime -= Time.deltaTime;
        if (gm.Waves > waves)
        {
            gif.kacke = false;
            Destroy(gameObject);
        }
    }    
}
