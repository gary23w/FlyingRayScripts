using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
public List<GameObject> smallBlocks;
public List<GameObject> largeBlocks;
public List<GameObject> platforms;
public List<GameObject> clouds;


public GameObject light;
public Transform player;


public int blocksToGenerate = 12;
public int cloudsToGenerate = 20;
public int lightToGenerate = 20;
int lightNumber = 1;
int blockNumber = 1;

public bool usePlatforms;

System.Random rand = new System.Random();

private void Awake() {
    for (int i = 0; i < blocksToGenerate; i++) {
        int smallBlockToGenerate = rand.Next(0, smallBlocks.Count);
        GameObject smallBlock = GameObject.Instantiate(smallBlocks[smallBlockToGenerate]);
        smallBlock.GetComponent<Block>().SetBlockNumberAndSpawn(blockNumber, transform, true);

        int largeBlockToGenerate = rand.Next(0, largeBlocks.Count);
        GameObject largeBlock = GameObject.Instantiate(largeBlocks[largeBlockToGenerate]);
        largeBlock.GetComponent<Block>().SetBlockNumberAndSpawn(blockNumber, transform, true);
        blockNumber++;
        
        GameObject lightBlock = GameObject.Instantiate(light);
        light.GetComponent<LightOperator>().SpawnAndSetBlockNumber(lightNumber, transform, true);
        lightNumber++;
        } 

        generatePlatforms();


    

    for(int i = 0; i < cloudsToGenerate; i++) {
        int cloudsToGenerate = rand.Next(0,clouds.Count);
        GameObject cloud = GameObject.Instantiate(clouds[cloudsToGenerate]);
        float cloudHeight = Random.Range(0f, 7f);
        float CloudDistance = Random.Range(0f, 7f);

        cloud.transform.position = new Vector3(CloudDistance, cloudHeight, 0);
        cloud.GetComponent<CloudMover>().SpawnCloud(transform);
    }

}
        public void generatePlatforms() {
                if(usePlatforms) {
                                int platformToGenerate = rand.Next(0, platforms.Count);
                                GameObject platform = GameObject.Instantiate(platforms[platformToGenerate]);
                                platform.GetComponent<Platform>().SetBlockNumberAndSpawn(blockNumber, transform, true);
                }   
            }
        }
