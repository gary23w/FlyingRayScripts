using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomBackground : MonoBehaviour
{
    public GameObject[] backGroundImages;
    public GameObject[] gameBackground;

    public FloatVariable DELTATIME;
    public Color[] colors;

    float startTime;

    float t;

    bool colorchangeyes = true;
    int keeptrack = 0;



    void Start() {
        if(PlayerPrefs.GetInt("GAMESTARTED") == 0) {
              t += Time.deltaTime / 1.5f;
                    DELTATIME.value = t;
                    PlayerPrefs.SetInt("GAMESTARTED", 1);
                    PlayerPrefs.SetFloat("TIME", t);
        }

                    startTime = Time.time;
                    randomColorMap();
    }
    public void randomColorMap() {
        try{
            t += PlayerPrefs.GetFloat("TIME") / 10;
        } catch {
            t += Time.time * startTime / 5;
            Debug.Log("Using catched time");
        }
                
        for(int i = 0; i < backGroundImages.Length; i++) {
            var color = colors[Random.Range(0, colors.Length)];
                  backGroundImages[i].GetComponent<RawImage>().color = Color.Lerp(backGroundImages[i].GetComponent<RawImage>().color, color, t);
                    try
                        {
                            gameBackground[i].GetComponent<RawImage>().color = Color.Lerp(backGroundImages[i].GetComponent<RawImage>().color, color, t);
              }
            catch (System.IndexOutOfRangeException e)  
            {
                Debug.Log("Game Background out of Range");
            }

        }

         Debug.Log("changing colors");
         StartCoroutine(changeBackgroundColor());
    }

    public void normalMap() {
        for(int i = 0; i < backGroundImages.Length; i++) {
            backGroundImages[i].GetComponent<RawImage>().color = Color.Lerp(backGroundImages[i].GetComponent<RawImage>().color, Color.white, Time.deltaTime * 2);
            gameBackground[i].GetComponent<RawImage>().color = Color.Lerp(gameBackground[i].GetComponent<RawImage>().color, Color.white, Time.deltaTime * 2);
            Debug.Log("background objects" + backGroundImages[i].ToString() + "colors. are now game default pattern.");
        }
    }

        IEnumerator changeBackgroundColor() {
            yield return new WaitForSeconds(8);
            if(keeptrack <= 29) {
                randomColorMap();
                keeptrack += 1;
                Debug.Log("changing backgrounds keep track" + keeptrack.ToString());
                StartCoroutine(changeBackgroundColor());
            } else {
                Debug.Log("Night time simulateda, now turning on the lights");
                StartCoroutine(lightsOn());
            }
            
        }
        IEnumerator lightsOn() {
            yield return new WaitForSeconds(5);
            normalMap();
            randomColorMap();
            keeptrack = 0;
        }

    public void changeMap() {
        for(int i = 0; i < backGroundImages.Length; i++) {
            var color = colors[Random.Range(0, colors.Length)];
                  backGroundImages[i].GetComponent<RawImage>().color = color;
                    try
                        {
                            gameBackground[i].GetComponent<RawImage>().color = color;
              }
            catch (System.IndexOutOfRangeException e)  
            {
                Debug.Log("Game Background out of Range");
            }

        }
    }


    }


  



