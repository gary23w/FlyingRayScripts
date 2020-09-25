using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSource : MonoBehaviour
{
    public GameObject playerAudioSource;
    public AudioClip gameMusic;

    public FloatVariable speakerActive;

    public FloatVariable score;

    void Awake() {
         playerAudioSource.GetComponent<AudioSource>().PlayOneShot(gameMusic, 0.05f); 
         if(speakerActive.value == 0) {
             speakerActive.value += 1;
             DontDestroyOnLoad(transform.gameObject);
         } else {
             Destroy(transform.gameObject);
         }
         
    }

    private void OnDestroy() {
        speakerActive.value = 0;
    }

}
