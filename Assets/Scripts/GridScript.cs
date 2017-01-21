using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour {

    public Color hoverColor;

    private GameObject turret;

    private SpriteRenderer myRenderer;
    private Color normalColor;

    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        normalColor = myRenderer.color;
    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);

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
