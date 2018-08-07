using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightReflector : MonoBehaviour {

    public string direction;
    public bool isActive;

    public GameObject lightBeamRef;
    GameObject lightBeam;
    public GameObject beamLocation;

    BoxCollider2D reflectorCollider;

	void Start () {
        reflectorCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isActive)
        {
            if (lightBeam == null)
            {
                lightBeam = Instantiate(lightBeamRef, beamLocation.transform.position, transform.rotation);
                lightBeam.transform.parent = gameObject.transform;
            }
        }
        else if (!isActive)
        {
            if(lightBeam != null)
            {
                Destroy(lightBeam);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player" && Input.GetKeyDown(KeyCode.E)){
            Debug.Log("Rotate");
            transform.Rotate(0, 0, 45);
        }
        if(collision.tag == "LightBeam")
        {
            isActive = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Reflector")
        collision.gameObject.GetComponent<LightReflector>().isActive = false;
    }

}
