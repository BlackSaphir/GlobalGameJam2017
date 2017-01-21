using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gif : MonoBehaviour
{
    public Animator animator;
    public DamsScript Dam;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        Dam = GetComponent<DamsScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Dam.damBroken)
        {
            animator.SetBool("existingDam", false);
        }
    }
}
