using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
public Transform blockGenerator;
int blockNumber;
bool smallBlock;

public void SetBlockNumberAndSpawn(int _blockNumber, Transform _blockGenerator, bool _smallBlock) {
    blockNumber = _blockNumber;
    blockGenerator = _blockGenerator;
    smallBlock = _smallBlock;
    Vector3 pos = Vector3.zero;
    pos.x = UnityEngine.Camera.main.transform.position.x + 2.0f + blockNumber;
    PlaceBlock(pos);

}



private void OnTriggerEnter2D(Collider2D collider) {
if(collider.tag == "BlockCleaner") {
    Move();
}
}




private void Move() {
Vector3 pos = transform.position;
pos.x = blockGenerator.position.x;
PlaceBlock(pos);
}

private void PlaceBlock(Vector3 pos) {
        if(smallBlock) {
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
