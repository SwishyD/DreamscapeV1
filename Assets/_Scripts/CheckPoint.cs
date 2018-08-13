using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public GameObject deathZone;

    // Use this for initialization
    void Start () {
		
	}

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GameManager.instance.currentCheckpoint = gameObject.transform.position;
            deathZone.transform.position =  new Vector3 (transform.position.x, transform.position.y - 7, 0);
        }
    }
}
