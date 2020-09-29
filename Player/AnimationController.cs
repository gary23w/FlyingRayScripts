using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    string BEAR = "isBear";
    string ONION = "isOnion";
    string BAT = "isBat";
    string MAIN = "FurJump";

    void Update()
    {
        if(PlayerPrefs.GetInt("WearingThisSkin") == 15) {
            isBearAnim();
        }
          if(PlayerPrefs.GetInt("WearingThisSkin") == 14) {
            isOnionAnim();
        }
          if(PlayerPrefs.GetInt("WearingThisSkin") == 13) {
            isBatAnim();
        } else {
            Debug.Log("Animations is everything");
        }
        
    }

    void isBearAnim(){
    animator.SetTrigger(BEAR);
    }
    void isOnionAnim() {
    animator.SetTrigger(ONION);
    }

    void isBatAnim() {
    animator.SetTrigger(BAT);
    }
    public void jumpFury() {
    animator.SetTrigger(MAIN);
    }
}
