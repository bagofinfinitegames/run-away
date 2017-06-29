using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Start it up");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickedIt(string message)
    {
        Debug.Log("Clicked " + message);
    }
}
