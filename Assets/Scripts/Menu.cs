using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {


        void OnGUI()
        {
            if (GUI.Button(new Rect(100, 200, 200, 100), "Play"))
            {
                Application.LoadLevel("GameScene");
            }
            if (GUI.Button(new Rect(100, 400, 200, 100), "Quit"))
            {
                Application.Quit();
            }
        }


        // Use this for initialization
        void Start()
        {

        }

    // Update is called once per frame
    void Update()
    {

    }
   
}
