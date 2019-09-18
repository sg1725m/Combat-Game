using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damageper : MonoBehaviour {

    public Slider healthbar;
    Animator anim;
    public string fighting;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != fighting) return;
        healthbar.value -= 5;

        if (healthbar.value <= 0)
            anim.SetBool("isDead", true);
    }


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
