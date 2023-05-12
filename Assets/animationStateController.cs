using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool IsWalking = animator.GetBool("IsWalking");
        bool IsAttacking = animator.GetBool("IsAttacking");

        bool ForwardPress = Input.GetKey("w");
        bool AttackPress = Input.GetKey("r");

        if (!IsWalking && ForwardPress)
        {
            animator.SetBool("IsWalking", true);
        }
        if (IsWalking && !ForwardPress)
        {
            animator.SetBool("IsWalking", false);
        }

        if (!IsAttacking && AttackPress)
        {
            animator.SetBool("IsAttacking", true);
        }
        if (IsAttacking && !ForwardPress)
        {
            animator.SetBool("IsAttacking", false);
        }


    }
}
