using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]

public class playermove : MonoBehaviour {

    Animator anim;
    bool isWalking = false;

   

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Turning();
        Walking();
        Move();

        Attack();
	}
    void Turning()
    {
        anim.SetFloat("Turn", Input.GetAxis("Horizontal"));

    }
    void Walking() 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isWalking = !isWalking;
            anim.SetBool("Walking", isWalking);
        }
        
    }
    void Move()
    { 
        anim.SetFloat("Forward", Input.GetAxis("Vertical"));
        
    } 
   void Attack()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            anim.SetTrigger("attack1");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            anim.SetTrigger("attack2");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            anim.SetTrigger("attack3");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            anim.SetTrigger("attack4");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            anim.SetTrigger("attack5");
        }
    }
    
}
