using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColorManager : MonoBehaviour
{
    private float nextChangeTime = 10f; // First trigger at 10 seconds
    private GameObject[] walls;

    void Start()
    {
        // Cache all walls at the beginning to avoid redundant searches
        walls = GameObject.FindGameObjectsWithTag("Walls");
    }

    void Update()
    {
        if (Time.time >= nextChangeTime)
        {
            ChangeWallColors(); // Trigger color shift
            nextChangeTime += 10f; // Schedule next change in 10 seconds
        }
    }

    void ChangeWallColors()
    {
        foreach (GameObject wall in walls)
        {
            Renderer wallRenderer = wall.GetComponent<Renderer>();
            //if (wallRenderer != null)
                StartCoroutine(FadeWallColor(wallRenderer, GetRandomColor(), 2f)); // Smooth transition

        }
    }

    IEnumerator FadeWallColor(Renderer renderer, Color targetColor, float duration)
    {
        Color startColor = renderer.material.GetColor("_TintColor"); // Retrieve current tint
        float timeElapsed = 0f;

        while (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            Color lerpedColor = Color.Lerp(startColor, targetColor, timeElapsed / duration);
            renderer.material.SetColor("_TintColor", lerpedColor); // Apply smooth tint transition
            yield return null;
        }
    }

    Color GetRandomColor()
    {
        float r = Random.Range(0, 255) / 255f;
        float g = Random.Range(0, 255) / 255f;
        float b = Random.Range(0, 255) / 255f;

        return new Color(r, g, b); // Generates random RGB tint
    }
}
