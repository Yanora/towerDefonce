using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoireScript : MonoBehaviour {


    void OnGUI()
    {
        if (GUI.Button(new Rect(100, 200, 200, 100), "Next Level"))
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene("boules_qui_roulent");
        }
        if (GUI.Button(new Rect(100, 400, 200, 100), "Replay"))
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene("boules_qui_roulent");
        }
        if (GUI.Button(new Rect(100, 600, 200, 100), "Back To the Menu"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }
        if (GUI.Button(new Rect(100, 800, 200, 100), "Quit"))
        {
            Application.Quit();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
