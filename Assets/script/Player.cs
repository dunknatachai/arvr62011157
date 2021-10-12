using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isRolling", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isRolling", false);
        }
    }
}
