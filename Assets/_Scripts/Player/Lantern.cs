using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GameManager.instance._lanternAcquired = true;
            gameObject.transform.parent = col.gameObject.transform;
        }
    }
}
