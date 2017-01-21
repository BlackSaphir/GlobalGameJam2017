using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamGridScript : MonoBehaviour
{
    public Color hoverColor;

    private GameObject dam;
    public GameObject prefab;

    private SpriteRenderer myRenderer;
    private Color normalColor;

    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        normalColor = myRenderer.color;
    }

    void OnMouseDown()
    {
        if (dam != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        GameObject damToBuild = BuildManager.instance.GetDam();
        dam = (GameObject)Instantiate(damToBuild, transform.position, transform.rotation);
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

