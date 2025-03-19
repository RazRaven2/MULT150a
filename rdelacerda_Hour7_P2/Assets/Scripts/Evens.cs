using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 22; i<101; i+=2)
            Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
