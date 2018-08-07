using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicbox : MonoBehaviour {

    AudioSource puzzleSounds;
    public AudioClip tune;
    bool canPlay = true;
    public int waitTimer;
    
    //public ParticleSystem ps;

  

 

	// Use this for initialization
	void Start () {
        puzzleSounds = GetComponent<AudioSource>();
    }

   

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player" && Input.GetKeyDown(KeyCode.E) && canPlay == true)
        {
            // ps.Play();
           
            Debug.Log("Activated");
            puzzleSounds.PlayOneShot(tune);
            canPlay = false;
            StartCoroutine("waitTime");


        }
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(waitTimer);
        canPlay = true;
    }
}
