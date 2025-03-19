using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i<32; i++)
            if(i==12){
                Debug.Log(i + " It's my birthday!!");
            }
            else{
                Debug.Log(i);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
