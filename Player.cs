using System.Collections;
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



    public AudioSource playerAudioSource;
    public AudioClip playerFlap;
    public AudioClip playerCrash;
    public AudioClip playerLight;
    public AudioClip gameMusic;





    void Awake()    {
        PlayerAlive.value = true;
        playerAudioSource.PlayOneShot(gameMusic, 0.1F);  
    }

    void Update()    {

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
           PlayerAlive.value = false;
            
           
        }
    }
}
