using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyColor : MonoBehaviour
{
    public GameObject gameObject;
    public Color dayTimeColor;
    public Color raining;
    Color lerpedColor = Color.white;

    void Start()
    {
        StartCoroutine(clearing());
    }
    void Update()
    {
        
    }
        IEnumerator clearing() {

        yield return new WaitForSeconds(15f);
        print("skyClearing");
        var colorsYay = gameObject.GetComponent<Renderer>();
        lerpedColor = Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 2));
        colorsYay.material.color = lerpedColor;
    
        }
}
