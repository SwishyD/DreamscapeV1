using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceCheck1 : MonoBehaviour {

    AudioSource puzzleSounds;
    public AudioClip tune;
    public AudioClip success;
    public AudioClip failure;

    public ParticleSystem ps;

    public static string correctSequence = "1212";
    public static string playerSequence = "";

    public static int totalDigits = 0;
    public GameObject nightmare;
    public GameObject bell;
    Animator nightmareAnim;
    Animator bellAnim;

    // Use this for initialization
    void Start () {
        puzzleSounds = GetComponent<AudioSource>();
        nightmareAnim = nightmare.GetComponent<Animator>();
        bellAnim = bell.GetComponent<Animator>();
        nightmareAnim.SetBool("isDead", false);
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(playerSequence);
        
        if (totalDigits == 4)
        {
            if(playerSequence == correctSequence)
            {
                nightmareAnim.SetBool("isDead", true);
                puzzleSounds.PlayOneShot(success);
                totalDigits = 0;
                Debug.Log("Correct!");
                playerSequence = "";
                nightmare.GetComponent<BoxCollider2D>().enabled = false;
                
            }
            else
            {
                nightmareAnim.SetTrigger("isScreaming");
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
            bellAnim.SetTrigger("bellRing");
            Debug.Log("Activated");
            puzzleSounds.PlayOneShot(tune);
            playerSequence += gameObject.name;
            totalDigits += 1;
            
        }
    }
}
