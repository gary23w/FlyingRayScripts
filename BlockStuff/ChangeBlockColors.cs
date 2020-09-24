using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlockColors : MonoBehaviour
{
//    public BlockGenerator blocksThatWereGenerated;
    public Color dayTimeColor;
    
    public Color raining;
    Color lerpedColor = Color.white;

    void Start()
    {
        // StartCoroutine(changingcolor());
    }
        // IEnumerator changingcolor() {
        // yield return new WaitForSeconds(5f);
        // print("Blocks Changing Color");
        // lerpedColor = Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 2));
        // for(int i = 0; i < blocksThatWereGenerated.smallBlocks.Length; i++) {
        //     blocksThatWereGenerated.smallBlocks[i].GetComponent<Renderer>().material.color = lerpedColor;
        // }
    
    
    }

    // IEnumerator changingBack() {
    //     yield return new WaitForSeconds(5f);
    //     print("Blocks going back to normal");
    //     var colorsYay = gameObject.GetComponent<Renderer>();
    //     lerpedColor = Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 2));
    //     colorsYay.material.color = lerpedColor;
    // }

