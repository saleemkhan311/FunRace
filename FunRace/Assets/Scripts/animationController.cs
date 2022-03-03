using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    float velocity;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButton(0))
        {
            velocity = 1.0f;

        }
        else if(!Input.GetMouseButton(0))
        {
            velocity = 0.0f;   
        }

        animator.SetFloat("Velocity", velocity);
    }
}
