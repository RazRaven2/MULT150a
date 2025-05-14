using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
     public GameObject prefab; // Assign your street lamp prefab in the Inspector
    public int lampCount = 10;
    public float spacing = 5f; // Distance between lamps
    // Start is called before the first frame update
   void Start()
    {
        for (int i = 0; i < lampCount; i++)
        {
            Vector3 spawnPosition = new Vector3(15, 0, (i * spacing)-15); // Position lamps in a line along X-axis
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
          // position of the original prefab
          // Whenever we hit the space key, we will generate a prefab at the
          // position of the spawn object that this script is attached to
          if (Input.GetKeyDown(KeyCode.B))
          {
               Instantiate(prefab);
          }
          if (Input.GetKeyDown(KeyCode.Space))
          {
               Instantiate(prefab, transform.position, transform.rotation);
          }
    }
}
