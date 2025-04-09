using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource; 
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ToggleAudio();
    }

    void ToggleAudio()
    {
        if (Input.GetKeyDown(KeyCode.Z))
       {
          if (audioSource.isPlaying == true)
               audioSource.Stop();
          else
               audioSource.Play();

        }
    }
}
