using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, Vector3.left, 1);
        if (hitLeft)
        {
            if(hitLeft.transform.tag == "Player")
            {
                Debug.Log("Collided");
            }
        }
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector3.right, 1);
        Debug.DrawRay(transform.position, Vector3.right, Color.red);
        if (hitRight)
        {
            Debug.Log(hitRight.transform.tag);
        }
    }

   
}
