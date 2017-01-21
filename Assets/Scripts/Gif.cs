using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gif : MonoBehaviour
{
    public Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("existingDam", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
