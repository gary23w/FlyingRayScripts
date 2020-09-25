using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
public Transform blockGenerator;

bool generateBlocks = true;
int blockNumber;
bool smallBlock;

private void Awake() {
    blockGenerator = GameObject.Find("BlockGenerator").transform;
}
        public void SetBlockNumberAndSpawn(int _blockNumber, Transform _blockGenerator, bool _smallBlock) {
            blockNumber = _blockNumber;
            blockGenerator = _blockGenerator;
            smallBlock = _smallBlock;
            Vector3 pos = Vector3.zero;
            pos.x = UnityEngine.Camera.main.transform.position.x + 90f;
            PlacePlatform(pos);

        }
        private void OnTriggerEnter2D(Collider2D collider) {
                if(collider.tag == "PlatformMover") {
                    Move();
                }
        }
        private void Move() {
                Vector3 pos = transform.position;
                pos.x = UnityEngine.Camera.main.transform.position.x + 100f;
                PlacePlatform(pos);
        }

            private void PlacePlatform(Vector3 pos) {
                pos.y = UnityEngine.Random.Range(0.1f, 0f);
                transform.position = pos;
        }
 }
