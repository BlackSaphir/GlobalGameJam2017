using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gif : MonoBehaviour
{
    public Animator animator;
    public DamsScript DamScript;
    public GameObject Dam;

    public bool kacke;
    // Use this for initialization
    void Start()
    {
        kacke = true;
        animator = GetComponent<Animator>();
        //Dam = GetComponent<GameObject>();
        DamScript = Dam.GetComponent<DamsScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(kacke);
        if (kacke == false)
        {
            animator.SetBool("existingDam", false);
        }
    }
}
