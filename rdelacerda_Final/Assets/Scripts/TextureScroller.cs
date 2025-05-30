using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        Vector2 offset = rend.material.mainTextureOffset;

        if (gameObject.CompareTag("Walls"))
        {
            // Scroll based on the wall's orientation
            if (transform.forward.y != 0) // If the wall is upright
                offset.y += scrollSpeed * Time.deltaTime; // Scroll vertically
            else
                offset.x += scrollSpeed * Time.deltaTime; // Scroll horizontally
        }
        else if (gameObject.CompareTag("Ground"))
        {
            offset.y += scrollSpeed * Time.deltaTime; // Scroll on y-axis
        }

        rend.material.mainTextureOffset = offset;
    }


}
