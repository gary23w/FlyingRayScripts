using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public GameObject player;
    public GameObject[] animatedBirds;
    public Color REDSKIN;
    public GameObject REDSKINOBJECT;
    public GameObject isPurchasedRedText;
    public Color YELLOWSKIN;
    public GameObject YELLOWSKINOBJECT;
    public GameObject isPurchasedYellowText;
    public Color PURPLESKIN;
    public GameObject PURPLESKINOBJECT;
    public GameObject isPurchasedPurpleText;
    public Color GREENSKIN;
    public GameObject GREENSKINOBJECT;
    public GameObject isPurchasedGreenText;
    public Color BLUESKIN;
    public GameObject BLUESKINOBJECT;
    public GameObject isPurchasedBlueText;
    public Color CYANSKIN;
    public GameObject CYANSKINOBJECT;
    public GameObject isPurchasedCyanText;
    public Color GREYSKIN;
    public GameObject GREYSKINOBJECT;
    public GameObject isPurchasedGreyText;
    public Color WHITESKIN;
    public GameObject WHITESKINOBJECT;
    public GameObject isPurchasedWhiteText;
    public Color BLACKSKIN;
    public GameObject BLACKSKINOBJECT;
    public GameObject isPurchasedBlackText;
    public Color CUSTOMSKINONE;
    public GameObject CUSTOMSKINONEOBJECT;
    public GameObject isPurchasedc1Text;
    public Color CUSTOMSKINTWO;
    public GameObject CUSTOmSKINTWOOBJECT;
    public GameObject isPurchasedc2Text;
    public Color CUSTOMSKINTHREE;
    public GameObject CUSTOMSKINTHREEOBJECT;
    public GameObject isPurchasedc3Text;





    public FloatVariable light;
    public GameObject storePanel;

    public GameObject notEnoughLight;

    public FloatVariable highScore;



    void Awake() {
            StopAnimations();
            updateItemText();
            switch(PlayerPrefs.GetInt("WearingThisSkin")) {
                case 1:
                isPurchasedRedText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 2:
                isPurchasedYellowText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 3:
                isPurchasedPurpleText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 4:
                isPurchasedGreenText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 5:
                isPurchasedBlueText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 6:
                isPurchasedCyanText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 7:
                isPurchasedGreyText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 8:
                isPurchasedWhiteText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 9:
                isPurchasedBlackText.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 10:
                isPurchasedc1Text.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 11:
                isPurchasedc2Text.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
                case 12:
                isPurchasedc3Text.GetComponent<UnityEngine.UI.Text>().text = "";
                break;
            }
    }

    public void turnRed() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedRed") == 1) {
                    getPlayer.material.color = Color.red;
                    PlayerPrefs.SetInt("WearingThisSkin", 1);
                    updateItemText();
                    isPurchasedRedText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(1);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.red;
       
        centerStage(1);
        PlayerPrefs.SetInt("PurchasedRed", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 1);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
    public void turnYellow() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedYellow") == 1) {
                    getPlayer.material.color = Color.yellow;
                    PlayerPrefs.SetInt("WearingThisSkin", 2);
                    updateItemText();
                    isPurchasedYellowText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(2);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.yellow;
        
        centerStage(2);
        PlayerPrefs.SetInt("PurchasedYellow", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 2);
        spentLightHundred();
        } else {
            notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
    public void turnPurple() {
          var getPlayer = player.GetComponent<SpriteRenderer>();
                if(PlayerPrefs.GetInt("PurchasedPurple") == 1) {
                    getPlayer.material.color = Color.magenta;
                    PlayerPrefs.SetInt("WearingThisSkin", 3);
                    updateItemText();
                    isPurchasedPurpleText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(3);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.magenta;
        centerStage(3);
        PlayerPrefs.SetInt("PurchasedPurple", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 3);
        spentLightHundred();
        } else {
            notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
        public void turnGreen() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedGreen") == 1) {
                    getPlayer.material.color = Color.green;
                    PlayerPrefs.SetInt("WearingThisSkin", 4);
                    updateItemText();
                    isPurchasedGreenText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(4);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.green;
       
        centerStage(4);
        PlayerPrefs.SetInt("PurchasedGreen", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 4);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
        public void turnBlue() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedBlue") == 1) {
                    getPlayer.material.color = Color.blue;
                    PlayerPrefs.SetInt("WearingThisSkin", 5);
                    updateItemText();
                    isPurchasedBlueText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(5);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.blue;
       
        centerStage(5);
        PlayerPrefs.SetInt("PurchasedBlue", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 5);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
        public void turnCyan() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedCyan") == 1) {
                    getPlayer.material.color = Color.cyan;
                    PlayerPrefs.SetInt("WearingThisSkin", 6);
                    updateItemText();
                    isPurchasedCyanText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(6);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.cyan;
       
        centerStage(6);
        PlayerPrefs.SetInt("PurchasedCyan", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 6);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
    public void turnGrey() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedGrey") == 1) {
                    getPlayer.material.color = Color.grey;
                    PlayerPrefs.SetInt("WearingThisSkin", 7);
                    updateItemText();
                    isPurchasedGreyText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(7);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.grey;
       
        centerStage(7);
        PlayerPrefs.SetInt("PurchasedGrey", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 7);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
        public void turnWhite() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedWhite") == 1) {
                    getPlayer.material.color = Color.white;
                    PlayerPrefs.SetInt("WearingThisSkin", 8);
                    updateItemText();
                    isPurchasedWhiteText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(8);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.white;
       
        centerStage(8);
        PlayerPrefs.SetInt("PurchasedWhite", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 8);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
    
        public void turnBlack() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedBlack") == 1) {
                    getPlayer.material.color = Color.black;
                    PlayerPrefs.SetInt("WearingThisSkin", 9);
                    updateItemText();
                    isPurchasedBlackText.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(9);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.black;
       
        centerStage(9);
        PlayerPrefs.SetInt("PurchasedBlack", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 9);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
     public void turnCustomOne() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedCustomOne") == 1) {
                    getPlayer.material.color = Color.black;
                    PlayerPrefs.SetInt("WearingThisSkin", 10);
                    updateItemText();
                    isPurchasedc1Text.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(10);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.black;
       
        centerStage(10);
        PlayerPrefs.SetInt("PurchasedCustomOne", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 10);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
    public void turnCustomTwo() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedCustomTwo") == 1) {
                    getPlayer.material.color = Color.black;
                    PlayerPrefs.SetInt("WearingThisSkin", 11);
                    updateItemText();
                    isPurchasedc2Text.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(11);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.black;
       
        centerStage(11);
        PlayerPrefs.SetInt("PurchasedCustomTwo", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 11);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
    public void turnCustomThree() {
        var getPlayer = player.GetComponent<SpriteRenderer>();
        if(PlayerPrefs.GetInt("PurchasedCustomThree") == 1) {
                    getPlayer.material.color = Color.black;
                    PlayerPrefs.SetInt("WearingThisSkin", 12);
                    updateItemText();
                    isPurchasedc3Text.GetComponent<UnityEngine.UI.Text>().text = "";
                    centerStage(12);
        }
        else if(light.value >= 100) {
        getPlayer.material.color = Color.black;
       
        centerStage(12);
        PlayerPrefs.SetInt("PurchasedCustomThree", 1);
        PlayerPrefs.SetInt("WearingThisSkin", 12);
        spentLightHundred();
        } else {
             notEnoughLight.transform.localScale = new Vector3(1,1,1);
        }
    }
    public void exitScreen(){
        storePanel.transform.localScale = Vector3.zero;
    }

    void spentLightHundred() {
        light.value -= 100;
    }
    void spentLightTwoHundred() {
        light.value -= 200;
    }
    public void buyLight() {
        light.value += 1000;
    }
    void centerStage(int stageNumber) {
        switch(stageNumber){
            case 1:
            StopAnimations();
            StartAnimations(0);
            break;
            case 2:
            StopAnimations();
            StartAnimations(1);
            break;
            case 3:
            StopAnimations();
            StartAnimations(2);
            break;
            case 4:
            StopAnimations();
            StartAnimations(3);
            break;
            case 5:
            StopAnimations();
            StartAnimations(4);
            break;
            case 6:
            StopAnimations();
            StartAnimations(5);
            break;
            case 7:
            StopAnimations();
            StartAnimations(6);
            break;
            case 8:
            StopAnimations();
            StartAnimations(7);
            break;
            case 9:
            StopAnimations();
            StartAnimations(8);
            break;
            case 10:
            StopAnimations();
            StartAnimations(9);
            break;
            case 11:
            StopAnimations();
            StartAnimations(10);
            break;
            case 12:
            StopAnimations();
            StartAnimations(11);
            break;
        }
    }
    public void whichSkin() {
    var getPlayer = player.GetComponent<SpriteRenderer>();
       switch(PlayerPrefs.GetInt("WearingThisSkin")) {
            case 1:
                    getPlayer.material.color = Color.red;
                    break;
            case 2:
                    getPlayer.material.color = Color.yellow;
                    break;
            case 3:
                    getPlayer.material.color = Color.magenta;
                    break;
            case 4:
                    getPlayer.material.color = Color.green;
                    break;
            case 5:
                    getPlayer.material.color = Color.blue;
                    break;
            case 6:
                    getPlayer.material.color = Color.cyan;
                    break;
            case 7:
                    getPlayer.material.color = Color.grey;
                    break;
            case 8:
                    getPlayer.material.color = Color.white;
                    break;
            case 9:
                    getPlayer.material.color = Color.black;
                    break;
            case 10:
                    getPlayer.material.color = Color.red;
                    break;
            case 11:
                    getPlayer.material.color = Color.yellow;
                    break;
            case 12:
                    getPlayer.material.color = Color.magenta;
                    break;

       }
      
    }
    void StopAnimations() {
            for(int i = 0; i < animatedBirds.Length; i++) {
                animatedBirds[i].GetComponent<Animator>().enabled = false;
                animatedBirds[i].transform.localScale = Vector3.zero;
        }
    }
    void StartAnimations(int Selected) {
        for(int i = 0; i < animatedBirds.Length; i++) {
            if (animatedBirds[Selected]) {
                animatedBirds[Selected].transform.localScale = new Vector3(1,1,1);
                animatedBirds[Selected].GetComponent<Animator>().enabled = true;
            }
        }

    }

    void updateItemText() {
        if(PlayerPrefs.GetInt("PurchasedRed") == 1) {
            isPurchasedRedText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedYellow") == 1) {
            isPurchasedYellowText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedPurple") == 1) {
            isPurchasedPurpleText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedGreen") == 1) {
            isPurchasedGreenText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedBlue") == 1) {
            isPurchasedBlueText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedCyan") == 1) {
            isPurchasedCyanText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedGrey") == 1) {
            isPurchasedGreyText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedWhite") == 1) {
            isPurchasedWhiteText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedBlack") == 1) {
            isPurchasedBlackText.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedCustomOne") == 1) {
            isPurchasedc1Text.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedCustomTwo") == 1) {
            isPurchasedc2Text.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        if(PlayerPrefs.GetInt("PurchasedCustomThree") == 1) {
            isPurchasedc3Text.GetComponent<UnityEngine.UI.Text>().text = "Equip";
        }
        
    }

}
