using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Camera : MonoBehaviour
{
    Transform playerTransform;
    public BoolVariable playerAlive;
    public GameObject fireworks;
    public GameObject rain;
    public GameObject mist;
    public FloatVariable score;
    public AudioSource audio;
    public AudioClip rainSound;


    float offsetx;
    void Awake() {
        audio.clip = rainSound;
    }
    void Start()

    {
        playerTransform = GameObject.FindWithTag("Player").transform;
        rain.GetComponent<ParticleSystem>().Play(); 
        mist.GetComponent<ParticleSystem>().Play();   
        audio.Play();
        offsetx = transform.position.x - playerTransform.position.x;
        fireworks.GetComponent<ParticleSystem>().Stop();
        
       
    }
    void Update()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
        Vector3 position = transform.position;
        position.x = playerTransform.position.x + offsetx;
        transform.position = position;
        
        
    }

    private void FixedUpdate () {
        if(score.value == 4800) {
            fireworks.GetComponent<ParticleSystem>().Play();
        } else if (score.value == 5100) {
            fireworks.GetComponent<ParticleSystem>().Stop();
        }
        if(score.value == 1500) {
            rain.GetComponent<ParticleSystem>().Stop();
            mist.GetComponent<ParticleSystem>().Stop();
            audio.Stop();
        } else if (score.value == 2500) {
            rain.GetComponent<ParticleSystem>().Play();
            mist.GetComponent<ParticleSystem>().Play();
            audio.Play();
        } else if(score.value == 3500) {
            rain.GetComponent<ParticleSystem>().Stop();
            mist.GetComponent<ParticleSystem>().Stop();
            audio.Stop();
        } else if(score.value == 4800) {
            rain.GetComponent<ParticleSystem>().Play();
            mist.GetComponent<ParticleSystem>().Play();
            audio.Play();
        } else if(score.value == 5700) {
            rain.GetComponent<ParticleSystem>().Stop();
            mist.GetComponent<ParticleSystem>().Stop();
            audio.Stop();
        } else if(score.value == 6700) {
            rain.GetComponent<ParticleSystem>().Play();
            mist.GetComponent<ParticleSystem>().Play();
            audio.Play();
        }

    }

}
