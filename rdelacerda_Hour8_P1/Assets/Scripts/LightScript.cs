using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Lightbulbs").GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        target.enabled = Input.GetKey(KeyCode.L);
    }
}
