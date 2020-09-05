using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Camera : MonoBehaviour
{
    public Transform playerTransform;

    public FloatVariable darkness;

    public BoolVariable playerAlive;

    public GameObject fireworks;

    public FloatVariable score;

    

    float offsetx;

    void Start()
    {
        offsetx = transform.position.x - playerTransform.position.x;
        darkness.value = 0;
        fireworks.GetComponent<ParticleSystem>().Stop();
    }
    void Update()
    {
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
    }
}
