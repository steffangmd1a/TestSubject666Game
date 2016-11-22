using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NewGame ()
    {

        Application.LoadLevel("intro");

    }

    public void LoadGame()
    {

        Application.LoadLevel("LoadScene");

    }

    public void QuitGame()
    {

        Application.Quit();

    }
}
