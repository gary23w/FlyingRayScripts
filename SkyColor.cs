using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyColor : MonoBehaviour
{
    public GameObject gameObject;
    public Color dayTimeColor;
    public Color nightTimeColor;
    Color lerpedColor = Color.white;

    void Start()
    {
        
       
        StartCoroutine(nightTime());
    }
    void Update()
    {
        
    }

        IEnumerator nightTime() {

        yield return new WaitForSeconds(15f);
        print("night time!@");
        var colorsYay = gameObject.GetComponent<Renderer>();
        lerpedColor = Color.Lerp(dayTimeColor, nightTimeColor, Mathf.PingPong(Time.time, 5));
        colorsYay.material.color = lerpedColor;
        StartCoroutine(dayTime());
    
    }
        IEnumerator dayTime() {
        yield return new WaitForSeconds(15f);
        print("day time!");
        var colorsYay = gameObject.GetComponent<Renderer>();
        lerpedColor = Color.Lerp(nightTimeColor, dayTimeColor, Mathf.PingPong(Time.time, 5));
        colorsYay.material.color = lerpedColor;
    }
}
