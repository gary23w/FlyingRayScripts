using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableRain : MonoBehaviour
{

    public GameObject rainPrefab;
    public GameObject rain;
    public GameObject mist;
    
    void Awake()
    {
        if(PlayerPrefs.GetInt("isRaining") == 0){
                
                    GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = true;
                    rainPrefab.SetActive(true);
                    rain.GetComponent<ParticleSystem>().Play(); 
                    mist.GetComponent<ParticleSystem>().Play(); 
         } else {
                    GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
                    rainPrefab.SetActive(false);
                    
        }
    }

    void Update()
    {
        
    }
    public void disableRainFunction() {
        if(PlayerPrefs.GetInt("isRaining") == 0){
                    GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
                    rainPrefab.SetActive(false);
                    PlayerPrefs.SetInt("isRaining", 1);
         } else {
                    GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = true;
                    rainPrefab.SetActive(true);
                    rain.GetComponent<ParticleSystem>().Play(); 
                    mist.GetComponent<ParticleSystem>().Play(); 
                    PlayerPrefs.SetInt("isRaining", 0);
        }
    }
}
