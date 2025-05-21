using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;
    Renderer renderer;
    float offset;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Increase Offset based on time
        offset += Time.deltaTime * speed;
        //Keep offset Between 0 and 1
        if (offset > 1)
            offset -= 1;
        //Apply the offset to the material
        renderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}
