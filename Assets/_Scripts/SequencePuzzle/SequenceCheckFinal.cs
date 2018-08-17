using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceCheckFinal : MonoBehaviour {

    AudioSource puzzleSounds;
    public AudioClip tune;
    public AudioClip success;
    public AudioClip failure;

    public ParticleSystem ps;

    public static string correctSequence = "121213456";
    public static string playerSequence = "";

    public static int totalDigits = 0;

	
	void Start () {
        puzzleSounds = GetComponent<AudioSource>();
    }
	
	
	void Update () {
       
        
        if (totalDigits == 9)
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



            ps.Play();

            Debug.Log("Activated");
            puzzleSounds.PlayOneShot(tune);
            playerSequence += gameObject.name;
            totalDigits += 1;

        }
    }
}
