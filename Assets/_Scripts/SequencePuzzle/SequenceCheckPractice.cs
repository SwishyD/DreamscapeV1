using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceCheckPractice : MonoBehaviour {

    AudioSource puzzleSounds;
    public AudioClip tune;
  

    public ParticleSystem ps;

  

 

	// Use this for initialization
	void Start () {
        puzzleSounds = GetComponent<AudioSource>();
    }
	


    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            ps.Play();
            Debug.Log("Activated");
            puzzleSounds.PlayOneShot(tune);
            
           
            
        }
    }
}
