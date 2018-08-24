using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {


    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject controlScreenUI;
    public GameObject quitConfirmUI;
    public GameObject menuConfirmUI;

    public static bool controlActive = false;
    public static bool quitActive = false;
    public static bool menuActive = false;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                if (controlActive == true)
                {
                    ReturnToPause();
                    controlActive = false;

                }
                else if (menuActive == true)
                {
                    ReturnToPause();
                    menuActive = false;
                    
                }
                else if (quitActive == true)
                {
                    ReturnToPause();
                    quitActive = false;
                    
                }
              
                else
                {
                    Resume();
                }
            }
            else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public  void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void QuitGameConfrim()
    {
        quitActive = true;
        pauseMenuUI.SetActive(false);
        quitConfirmUI.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScreenCody");        
    }

    public void ControlScreen()
    {
        controlActive = true;
        pauseMenuUI.SetActive(false);
        controlScreenUI.SetActive(true);
    }

    public void ReturnToPause()
    {
        pauseMenuUI.SetActive(true);
        controlScreenUI.SetActive(false);
        quitConfirmUI.SetActive(false);
        menuConfirmUI.SetActive(false);
    }

    public void MenuConfrim()
    {
        menuActive = true;
        pauseMenuUI.SetActive(false);
        menuConfirmUI.SetActive(true);
    }

}
