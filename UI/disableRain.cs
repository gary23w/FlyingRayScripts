using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableRain : MonoBehaviour
{

    public GameObject rainPrefab;
    public GameObject rain;
    public GameObject mist;

    public FloatVariable speakerActive;
    
    void Awake()
    {
        if(PlayerPrefs.GetInt("isRaining") == 0){
                
                    GameObject.Find("RainAudio").GetComponent<AudioSource>().enabled = true;
                    rainPrefab.SetActive(true);
                    rain.GetComponent<ParticleSystem>().Play(); 
                    mist.GetComponent<ParticleSystem>().Play(); 
                     speakerActive.value = 1;
         } else {
                    GameObject.Find("RainAudio").GetComponent<AudioSource>().enabled = false;
                    rainPrefab.SetActive(false);
                    speakerActive.value = 1;
                    
        }
    }

    void Update()
    {
        
    }
    public void disableRainFunction() {
        if(PlayerPrefs.GetInt("isRaining") == 0){
                    GameObject.Find("RainAudio").GetComponent<AudioSource>().enabled = false;
                    rainPrefab.SetActive(false);
                    PlayerPrefs.SetInt("isRaining", 1);
                    speakerActive.value = 1;
         } else {
                    GameObject.Find("RainAudio").GetComponent<AudioSource>().enabled = true;
                    rainPrefab.SetActive(true);
                    rain.GetComponent<ParticleSystem>().Play(); 
                    mist.GetComponent<ParticleSystem>().Play(); 
                    PlayerPrefs.SetInt("isRaining", 0);
                    speakerActive.value = 1;
        }
    }
}
