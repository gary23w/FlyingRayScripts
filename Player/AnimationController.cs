using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    string BEAR = "isBear";
    string ONION = "isOnion";
    string BAT = "isBat";
    string MAIN = "isMain";

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
            isMainAnim();
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
    void isMainAnim() {
    animator.SetTrigger(MAIN);
    }
}
