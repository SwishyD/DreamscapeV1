using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpHeight = 4;
    public float timeToJumpApex = .4f;
    float accelerationTimeAirborne = .2f;
    float accelerationTimeGrounded = .1f;
    float moveSpeed = 6;

    public bool canMove = false;

    AudioSource sound;
    public AudioClip thud;
    public GameObject dustEffect;
    private bool spawnDust;
    public GameObject dustSpawn;

    float gravity;
    float jumpVelocity;
    Vector3 velocity;
    float velocityXSmoothing;

    Controller2D controller;

    Vector2 input;

    private Animator anim;
    private SpriteRenderer rend;

    public GameObject dustEffect;
    private bool spawnDust;

    void Start () {
        controller = GetComponent<Controller2D>();
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex, 2);
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
	}
	
	// Update is called once per frame
	void Update () {

        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
            if (spawnDust == true)
            {
                GameObject tempParticle = Instantiate(dustEffect, dustSpawn.transform.position, Quaternion.identity);
                sound.PlayOneShot(thud);
                Destroy(tempParticle, 1);
            }
            spawnDust = false;
            anim.SetBool("isJumping", false);
        }
        if (canMove == true)
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }

        if((Input.GetKeyDown(KeyCode.Space) && controller.collisions.below) && canMove == true)
        {
            velocity.y = jumpVelocity;
            spawnDust = true;
            anim.SetBool("isJumping", true);
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && canMove == true)
        {
            anim.SetBool("isRunning", true);
            rend.flipX = true;
        }
        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && canMove == true)
        {
            anim.SetBool("isRunning", true);
            rend.flipX = false;
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        float targetVelocityX  = input.x * moveSpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below)?accelerationTimeGrounded:accelerationTimeAirborne);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
	}


    
   
}
