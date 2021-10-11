using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isRoll", true); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isRoll", false);
        }

    }
}
