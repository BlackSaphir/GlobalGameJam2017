using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {
            Debug.Log("Error, more than one BuildManagers in Scene!");
            return;
        }
        instance = this;    
    }

    public GameObject standardTurret;

    public GameObject DamPrefab;

    private GameObject buildTurret;

    void Start()
    {
        buildTurret = standardTurret;
    }

    public GameObject GetTurretToBuild()
    {
        return buildTurret;
    }

    public GameObject GetDam()
    {
        return DamPrefab;
    }
}
