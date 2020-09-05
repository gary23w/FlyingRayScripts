using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOperator : MonoBehaviour
{
   Transform blockGenerator;
   public FloatVariable lightHorder;
   int blockNumber;
   bool smallLight;

   public float lightGenerated = 0.2f;

   void Awake() {
       blockGenerator = GameObject.Find("BlockGenerator").transform;
   }


    public void SpawnAndSetBlockNumber(int _blockNumber, Transform _blockGenerator, bool isLit) {

    blockNumber = _blockNumber;
    blockGenerator = _blockGenerator;
    smallLight = isLit;
    Vector3 pos = Vector3.zero;
    pos.x = UnityEngine.Camera.main.transform.position.x + 2.0f + blockNumber;
    PlaceLight(pos);
}

   void EnableRenderer() {
       GetComponent<Renderer>().enabled = true;
   }

   private void OnTriggerEnter2D(Collider2D collider) {
     if(collider.tag == "Player") {
           GetComponent<Renderer>().enabled = false;
           Invoke("EnableRenderer", 3f);
           lightHorder.value += 1;

     } else if(collider.tag == "BlockCleaner") {
          Move();
   }
}




    private void Move() {
        Vector3 pos = transform.position;
        pos.x = blockGenerator.position.x;
        PlaceLight(pos);
    }

    private void PlaceLight(Vector3 pos) {
        if(smallLight) {
            if(blockNumber % 3 == 0) {
            pos.y = UnityEngine.Random.Range(0.1f, -2.0f);
            
        } else {
            pos.y = UnityEngine.Random.Range(0.1f, 4.0f);
        }
        } else {
            if(blockNumber % 3 != 0) {
            pos.y = UnityEngine.Random.Range(0.1f, -2.0f);
            
        } else {
            pos.y = UnityEngine.Random.Range(0.1f, 4.0f);
        }
    }
         transform.position = pos;
}

}
