using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkNightmare : MonoBehaviour {

    Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
        anim.SetBool("isDead", false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "LightBeam")
        {
            anim.SetBool("isDead", true);
            GetComponent<BoxCollider2D>().enabled = false;

        }
    }
}
