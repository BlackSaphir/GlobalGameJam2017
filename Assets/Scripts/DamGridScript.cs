using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamGridScript : MonoBehaviour
{
    public Color hoverColor;

    public GameObject dam;
    public GameObject prefab;
    public WaveMovement waveMovment;

    private SpriteRenderer myRenderer;
    private Color normalColor;

    public Gif gif;

    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        normalColor = myRenderer.color;
        //GameObject damToBuild = BuildManager.instance.GetDam();
        dam = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
    }

    void Update()
    {
        if(dam == null)
        {
            gif.kacke = false;
            //waveMovment.brokenDam = true;
        }        
    }

    void OnMouseDown()
    {
        if (dam != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        //GameObject damToBuild = BuildManager.instance.GetDam();
        dam = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
    }

    void OnMouseEnter()
    {
        myRenderer.color = hoverColor;
    }

    void OnMouseExit()
    {
        myRenderer.color = normalColor;
    }
}

