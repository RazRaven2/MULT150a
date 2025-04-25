using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GoalScript blue, green, red, orange, chaos;
    // Flags that control the state of the game
    public GameObject player;
	public float elapsedTime = 0;
	public bool isRunning = false;
	public bool isFinished = false;
	// So that we can access the player's controller from this script
	public FirstPersonController fpsController;
    public bool isGameOver = true;
    void Start ()
	{
		//Finds Player
        player = GameObject.FindWithTag("Player");
        // Finds the First Person Controller script on the Player
		fpsController = player.GetComponent<FirstPersonController> ();
	
		// Disables controls at the start.
		fpsController.enabled = false;
		Time.timeScale = 0;
	}
    
    
    void Update ()
    {
        // If all four goals are solved then the game is over
       isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;

       // Add time to the clock if the game is running
		if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}
    }
    void OnGUI()
    {
		if(!isRunning)
		{
			string message;

			if(isFinished)
			{
				message = "Click or Press Enter to Play Again";
			}
			else
			{
				message = "Click or Press Enter to Play";
			}
            //Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/3, 240, 30);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
				if(isGameOver)
				{
					Restart();	
				}
				else
				{
					//start the game if the user clicks to play
					StartGame ();
				}
			}
		}
        //GUI Messeges
        if(isRunning)
		{ 
			// If the game is running, show the current time
			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
		}
        if(isGameOver)
        {
            Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box (rect, "Game Over");
            Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label (rect2, "Good Job! Time: "+((int)elapsedTime).ToString());
			isFinished = true;
			isRunning = false;
        }
    }
    void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isFinished = false;

		// the player allowed to move.
		fpsController.enabled = true;
		Time.timeScale = 1;
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
