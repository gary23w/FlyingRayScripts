using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class birdmodeCamera : MonoBehaviour
{
    public Transform playerTransform;
    public BoolVariable playerAlive;
    public FloatVariable score;
    float offsetx;

    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
        offsetx = transform.position.x - playerTransform.position.x;
       
    }
    void Update()
    {
        Vector3 position = transform.position;
        position.x = playerTransform.position.x + offsetx;
        transform.position = position;
        
    }

    private void FixedUpdate () {

    }

}
