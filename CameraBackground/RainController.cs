using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip rainSounds;

    void Awake() {
        audio.clip = rainSounds;
        if(PlayerPrefs.GetInt("isRaining") == 0){
                audio.Play();
         } else {
                audio.Stop();            
        }
    }
    void Start()
    {
        
    }
}
