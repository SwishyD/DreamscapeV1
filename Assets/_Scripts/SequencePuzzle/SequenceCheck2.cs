using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceCheck2 : MonoBehaviour {

    AudioSource puzzleSounds;
    public AudioClip tune;
    public AudioClip success;
    public AudioClip failure;

    public ParticleSystem ps;

    public static string correctSequence = "121213";
    public static string playerSequence = "";

    public static int totalDigits = 0;

	// Use this for initialization
	void Start () {
        puzzleSounds = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(playerSequence);
        
        if (totalDigits == 6)
        {
            if(playerSequence == correctSequence)
            {
                puzzleSounds.PlayOneShot(success);
                totalDigits = 0;
                Debug.Log("Correct!");
                playerSequence = "";
                
            }
            else
            {
                puzzleSounds.PlayOneShot(failure);
                playerSequence = "";
                Debug.Log("Incorrect!");
                totalDigits = 0;
            }
        }
	}

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            ps.Play();
            Debug.Log("Activated");
            puzzleSounds.PlayOneShot(tune);
            playerSequence += gameObject.name;
            totalDigits += 1;
            
        }
    }
}
