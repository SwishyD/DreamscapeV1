using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    //Detects collisions with player and calls function (Call sequence check!)
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Collided");
        }
    }
}
 