using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "Game";
public GameObject targetObject;
	public Collidable scriptToEnable;
	



	public void LoadStart()
	{
		StartCoroutine(LoadGame());
		EnableCollidableScript();
	}
	public IEnumerator LoadGame()
	{
		
		yield return new WaitForSeconds(2.5f);
		SceneManager.LoadScene(sceneToLoad);
	}
	public void EnableCollidableScript()
    {
        if (targetObject != null)
        {
            scriptToEnable = targetObject.GetComponent<Collidable>();
            if (scriptToEnable != null)
                scriptToEnable.enabled = true; // Enable the Collidable script
        }

    }



}
