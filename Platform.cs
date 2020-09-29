using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
public Transform blockGenerator;
public Transform platformNewLocation;

public Transform platformNewLocationTwo;

bool generateBlocks = true;
int blockNumber;
bool smallBlock;
public FloatVariable GameRunning;

BlockGenerator blockGeneratorScript;
Vector3 pos = Vector3.zero;

private void Awake() {
    blockGenerator = GameObject.Find("BlockGenerator").transform;
    blockGeneratorScript = GameObject.Find("BlockGenerator").GetComponent<BlockGenerator>();
    platformNewLocation = GameObject.Find("PlatFormLocation").transform;
      platformNewLocationTwo = GameObject.Find("PlatFormLocationTwo").transform;
}
        public void SetBlockNumberAndSpawn(int _blockNumber, Transform _blockGenerator, bool _smallBlock) {
            blockNumber = _blockNumber;
            blockGenerator = _blockGenerator;
            smallBlock = _smallBlock;
            pos = Vector3.zero;
            if(GameRunning.value == 0) {
                pos.x = platformNewLocation.transform.position.x;
            } else {
                 pos.x = platformNewLocationTwo.transform.position.x;
            }
            GameRunning.value += 1;
            PlacePlatform(pos);
           
        }
        private void OnTriggerEnter2D(Collider2D collider) {
                if(collider.tag == "PlatformMover") {
                    spawnDifferentPlatform();
                    Destroy(this.gameObject);               
            }
        }
        private void PlacePlatform(Vector3 pos) {
                pos.y = 0f;
                transform.position = pos;
        }

        public void spawnDifferentPlatform() {
            blockGeneratorScript.generatePlatforms();
        }

 }
