using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Main Menu!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    public void ClickedIt(string message)
    {
        Debug.Log("Clicked " + message);
    }
}
