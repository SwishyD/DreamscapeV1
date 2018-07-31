using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        SceneManager.LoadScene("lvl1Cody");
    }

    
    public void ControlsMenu()
    {

    }

    public void Credits()
    {

    }

    public void QuitGameConfirmation()
    {

    }

}
