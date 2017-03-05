using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaiteScript : MonoBehaviour {



    void OnGUI()
    {
        if (GUI.Button(new Rect(100, 200, 200, 100), "RePlay"))
        {
<<<<<<< HEAD
            //UnityEngine.SceneManagement.SceneManager.LoadScene("boules_qui_roulent");
        }
        if (GUI.Button(new Rect(100, 400, 200, 100), "Back To the Menu"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
=======
            Application.LoadLevel("GameScene");
        }
        if (GUI.Button(new Rect(100, 400, 200, 100), "Back To the Menu"))
        {
            Application.LoadLevel("Menu");
>>>>>>> master
        }
        if (GUI.Button(new Rect(100, 600, 200, 100), "Quit"))
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
