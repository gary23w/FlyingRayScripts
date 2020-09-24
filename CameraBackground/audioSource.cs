using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSource : MonoBehaviour
{
    public GameObject playerAudioSource;
    public AudioClip gameMusic;

    void Awake() {
         playerAudioSource.GetComponent<AudioSource>().PlayOneShot(gameMusic, 0.1F);  
         DontDestroyOnLoad(transform.gameObject);
    }

}
