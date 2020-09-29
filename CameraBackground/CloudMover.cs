using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMover : MonoBehaviour
{

    Transform blockGenerator;
    Vector3 moveSpeed;

    void Awake() {
        blockGenerator = GameObject.Find("BlockGenerator").transform;
    }

    public void SpawnCloud(Transform blockGenerator) {

        moveSpeed.x = Random.Range(-.3f, 0f);

        this.blockGenerator = blockGenerator;

    }

    private void FixedUpdate() {
        transform.position += moveSpeed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "BlockCleaner") {
            Vector3 pos = transform.position;
            pos.x = blockGenerator.position.x;
            pos.y = Random.Range(-1.0f, 7.0f);

            moveSpeed.x = Random.Range(-.3f, 0f);
            transform.position = pos;
        }
    }
}
