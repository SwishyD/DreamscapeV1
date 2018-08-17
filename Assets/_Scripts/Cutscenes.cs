using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscenes : MonoBehaviour {

    public GameObject gameCamera;
    public GameObject cutsceneCamera;
    public GameObject player;


	// Use this for initialization
	void Start () {
        gameCamera.SetActive(false);
        cutsceneCamera.SetActive(true);
        player.GetComponent<Player>().canMove = false;
        StartCoroutine("GameStart");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(8);
        gameCamera.SetActive(true);
        cutsceneCamera.SetActive(false);
        player.GetComponent<Player>().canMove = true;
    }


}
