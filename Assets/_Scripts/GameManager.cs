using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    
    public GameObject deathZone;
    public GameObject player;

    public Vector3 currentCheckpoint;


    public bool _lanternAcquired = false;
   

    public static GameManager instance = null;

    void Awake()
    {
        Time.timeScale = 1;
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {

		
	}

    public void Respawn()
    {
        if (_lanternAcquired == true)
        {
            SceneManager.LoadScene("lvl2Cody");
        }
        else
        {
            player.transform.position = currentCheckpoint;
        }
    }

    
   
}
