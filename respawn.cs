using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respawn : MonoBehaviour
{
    public Slider healthbar;      
    public float restartDelay = 2f;        



    float restartTimer;               


    void Awake()
    {
        
    }


    void Update()
    {
        // If the player has run out of health...
        if (healthbar.value <= 0)
        {
           

            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
             
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
