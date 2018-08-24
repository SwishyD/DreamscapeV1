using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonHover : MonoBehaviour
{

    AudioSource mySound;
    public AudioClip hover;

    private void Start()
    {
        mySound = GetComponent<AudioSource>();
    }

    private void OnMouseOver()
    {
        mySound.PlayOneShot(hover);
    }

}
