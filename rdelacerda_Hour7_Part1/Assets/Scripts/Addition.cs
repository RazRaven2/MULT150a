using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public int sum;

    

    // Start is called before the first frame update
    void Start()
    {
        a = 2;
        b = 4;
        c = 8;

        sum = a + b + c;
        sum++;

        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
