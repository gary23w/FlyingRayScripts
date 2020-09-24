﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Player : MonoBehaviour {
    Vector3 velocity = Vector3.zero;
    public Vector3 gravity;
    public BoolVariable PlayerAlive;

    bool didFlap = false;
    public Vector3 flapVelocity;
    public float maxSpeed = 5f;
    public float forwardSpeed = 1f;

    public GameObject animExplosion;
     



    public AudioSource playerAudioSource;
    public AudioClip playerFlap;
    public AudioClip playerCrash;
    public AudioClip playerLight;

    bool playExplosion;





    void Awake()    {
        PlayerAlive.value = true;
        animExplosion.GetComponent<Animator>().enabled = false;
        animExplosion.transform.localScale = Vector3.zero;

    }

    void Update()    {
        if(playExplosion) {
                    animExplosion.GetComponent<Animator>().enabled = true;
                      animExplosion.transform.localScale = new Vector3(1,1,1);
        }

        if(Input.GetMouseButtonDown(0)) {
            didFlap = true;
        }
    }

    private void FixedUpdate() {
        if(PlayerAlive.value) {
        MovePlayer();
        }
       
    }
    private void MovePlayer() {
        velocity.x = forwardSpeed;
        
        velocity += gravity;

        if(didFlap) {
            playerAudioSource.PlayOneShot(playerFlap);
            didFlap = false;
            if(velocity.y < 0) {
                velocity.y = 0;
            }

            velocity += flapVelocity;
        }
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position += velocity * Time.fixedDeltaTime;

        float angle = 0;

        if(velocity.y < 0) {
            angle = Mathf.Lerp(0, -99, -velocity.y / maxSpeed);
        } else {
            angle = Mathf.Lerp(0, 50, +velocity.y / maxSpeed);
        }

        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.transform.tag == "Light") {
            playerAudioSource.PlayOneShot(playerLight);
        }
        else if(collision.transform.tag != "Sky") {
           
           playerAudioSource.PlayOneShot(playerCrash);
           Debug.Log("GAME OVER - player");
           playExplosion = true;

           StartCoroutine(PlayerDied());           
        }
    }
    void playerExplode() {
        transform.localScale = Vector3.zero;
        animExplosion.transform.localScale = new Vector3(1,1,1);
        animExplosion.GetComponent<Animator>().enabled = true;

    }
        IEnumerator PlayerDied() {

        yield return new WaitForSeconds(0.4f);
        print("yielding");
        PlayerAlive.value = false;
    
    }

}