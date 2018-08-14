using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private static bool created = false;

    public GameObject deathZone;
    public GameObject player;

    public Vector3 currentCheckpoint;


    public bool _lanternAcquired = false;
   

    public static GameManager instance = null;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(gameObject);
            created = true;
            Debug.Log("Awake: " + gameObject);
        }
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            player.transform.position = currentCheckpoint;
        }
    }

    
   
}
