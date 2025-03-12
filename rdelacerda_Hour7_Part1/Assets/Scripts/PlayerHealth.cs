using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float poisonDamage;

    // Start is called before the first frame update
    void Start()
    {
        health = 1004f;
        poisonDamage = 125.5f;

        Debug.Log(health);

        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        
        Debug.Log("The player has been unalived!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
