using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWon : MonoBehaviour {

	// Use this for initialization
	void RestartLevel () {
		Application.LoadLevel ("Victoire");
	}

}
