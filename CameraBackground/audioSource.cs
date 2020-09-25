using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSource : MonoBehaviour
{
    public GameObject playerAudioSource;
    public AudioClip gameMusic;

    public FloatVariable score;

    void Awake() {
        int numMusicPlayers = FindObjectsOfType<audioSource>().Length;
         playerAudioSource.GetComponent<AudioSource>().PlayOneShot(gameMusic, 0.05f); 
         Debug.Log(numMusicPlayers.ToString());
         if(numMusicPlayers != 1) {
              Destroy(this.gameObject);
         } else {
              DontDestroyOnLoad(this);
         }
         
    }
}
