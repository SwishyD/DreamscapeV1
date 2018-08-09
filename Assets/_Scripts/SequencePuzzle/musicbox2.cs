﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicbox2 : MonoBehaviour {

    AudioSource puzzleSounds;
    public AudioClip tune;
    bool canPlay = true;
    public int waitTimer;
    public ParticleSystem note1;
    public ParticleSystem note2;
    public ParticleSystem note3;






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
        note1.Play();
        yield return new WaitForSeconds(waitTimer);
        note2.Play();
        yield return new WaitForSeconds(waitTimer);
        note1.Play();
        yield return new WaitForSeconds(waitTimer);
        note2.Play();
        yield return new WaitForSeconds(waitTimer);
        note1.Play();
        yield return new WaitForSeconds(waitTimer);
        note3.Play();
        yield return new WaitForSeconds(waitTimer);
        canPlay = true;
    }
}