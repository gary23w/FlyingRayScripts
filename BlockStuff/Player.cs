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

    GameObject MainCamera;

    public GameObject animExplosion;
     



    public AudioSource playerAudioSource;
    public AudioClip playerFlap;
    public AudioClip playerCrash;
    public AudioClip playerLight;

    bool playExplosion;

    bool running = false;
    public FloatVariable section;
    public FloatVariable gameRunning;

    RandomBackground changeColors;

    AnimationController animationController;
    public bool isFurry;
    





    void Awake()    {
        PlayerAlive.value = true;
        animExplosion.GetComponent<Animator>().enabled = false;
        animExplosion.transform.localScale = Vector3.zero;
        MainCamera = GameObject.FindWithTag("MainCamera");
        animationController = this.gameObject.GetComponent<AnimationController>();
      
    }

    void Update()    {
        if(playExplosion) {
                    animExplosion.GetComponent<Animator>().enabled = true;
                      animExplosion.transform.localScale = new Vector3(1,1,1);
        }

        if(Input.GetMouseButtonDown(0)) {
            if(isFurry) {
                  animationController.jumpFury();
            }
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
        if(!running) {
            if(velocity.y < 0) {
                angle = Mathf.Lerp(0, -99, -velocity.y / maxSpeed);
            } else {
                angle = Mathf.Lerp(0, 50, +velocity.y / maxSpeed);
            }
       
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);   

    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.transform.tag == "Light") {
            playerAudioSource.PlayOneShot(playerLight);
        }
        if(collision.transform.tag == "Floor") {
            Debug.Log("lets start walking");
            didFlap = false;
        }
        if(collision.transform.tag == "GroundCollider" || collision.transform.tag == "Blocks") {
           playerAudioSource.PlayOneShot(playerCrash);
           Debug.Log("GAME OVER - player");
           playExplosion = true;
           gameRunning.value = 0;
           StartCoroutine(PlayerDied());           
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "runmode") {
            Debug.Log("RUNMODE INITIATED");
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            MainCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp(7f, 4.88f, Time.deltaTime);
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
            running = true;
        }
        if(other.transform.tag == "flymode") {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
            section.value += 1;
            running = false;
            didFlap = true;
        }
        
    }
    void playerExplode() {
        transform.localScale = Vector3.zero;
        animExplosion.transform.localScale = new Vector3(1,1,1);
        animExplosion.GetComponent<Animator>().enabled = true;

    }
        IEnumerator PlayerDied() {
        yield return new WaitForSeconds(0.4f);
        PlayerAlive.value = false;
    
    }

}
