using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public GameObject deathZone;
    public GameObject[] platforms;
    public bool deathZoneMove = true;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < platforms.Length; i++)
        {
            platforms[i].GetComponent<PlatformController>().enabled = false;
        }

    }

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            GameManager.instance.currentCheckpoint = gameObject.transform.position;

            if (deathZoneMove == true)
            {
                deathZone.transform.position = new Vector3(transform.position.x, transform.position.y - 10, 0);
            }
            for(int i = 0; i < platforms.Length; i++)
            {
                platforms[i].GetComponent<PlatformController>().enabled = true;
            }

        }
    }
}
