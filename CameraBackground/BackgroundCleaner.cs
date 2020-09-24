using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCleaner : MonoBehaviour
{

    public float distance = 1.33f;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Background") {
            float widthofObject = ((BoxCollider2D)collision).size.x;

            Vector3 position = collision.transform.position;

            position.x += widthofObject * distance;

            collision.transform.position = position;
        } 

    }
}
