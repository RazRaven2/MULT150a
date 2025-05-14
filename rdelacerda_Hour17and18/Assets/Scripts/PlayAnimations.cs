using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimations : MonoBehaviour
{
    public Animator animator;
    public string animationName1 = "Street_Lamp_Rotation"; //animation's name
    public string animationName2 = "Street_Lamp_colors"; //animation's name
    public string animationName3 = "Street_Lamp_Size"; //animation's name
    public string animationName4 = "Street_Lamp_Hover"; //animation's name

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play(animationName1);
        }
         if (Input.GetKeyDown(KeyCode.A))
        {
            animator.Play(animationName2);
        }
         if (Input.GetKeyDown(KeyCode.D))
        {
            animator.Play(animationName3);
        }
         if (Input.GetKeyDown(KeyCode.W))
        {
            animator.Play(animationName4);
        }
    }
}

