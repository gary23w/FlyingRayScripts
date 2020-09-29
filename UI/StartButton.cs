using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour
{
    public GameObject startButton;
    public GameObject pauseButton;
    public GameObject resume;
    public GameObject endScene;
    public GameObject storeButton;
    public GameObject storePanel;
    public GameObject mainScreenPanel;
    public GameObject dropDownMenuGO;
    public GameObject newSceneButton;
    public GameObject CreditPanel;
    public Player player;
    GameObject currentPlayerObject;
    public Store store;
    public BoolVariable hardModeBool;
    public BoolVariable expertModeBool;
    public FloatVariable section;
    

    int GameMode = 0;
    

    void Awake() {
        Time.timeScale = 0;
        currentPlayerObject = GameObject.FindWithTag("Player");
        player = currentPlayerObject.GetComponent<Player>();
        store.whichSkin(); 
        switch(PlayerPrefs.GetInt("GameModeSelection")) {
            case 0:
            Debug.Log("Normal mode selected");
            GameMode = 0;
            dropDownMenuGO.GetComponent<Dropdown>().value = 0;
            break;
            case 1:
            Debug.Log("hard mode");
            GameMode = 1;
            dropDownMenuGO.GetComponent<Dropdown>().value = 1;
            break;
            case 2:
            Debug.Log("expert mode");
            GameMode = 2;
            dropDownMenuGO.GetComponent<Dropdown>().value = 2;
            break;
        }
        
    }
    void Update() {
         dropDownMenu(); 
        currentPlayerObject = GameObject.FindWithTag("Player");
        player = currentPlayerObject.GetComponent<Player>();

    }
    public void StartGame() {
                    player.maxSpeed = 3f;
                    player.forwardSpeed = 2.5f;
                    transform.localScale = Vector3.zero; 
                    pauseButton.transform.localScale = new Vector3 (1, 1, 1);
                    storeButton.transform.localScale = Vector3.zero;
                    mainScreenPanel.transform.localScale = Vector3.zero;
                    dropDownMenuGO.transform.localScale = Vector3.zero;
                    section.value = 0;
                    StartCoroutine(waitForStart());
        if (GameMode == 1) {
                        player.maxSpeed = 5f;
                        player.forwardSpeed = 4f;
                        transform.localScale = Vector3.zero;
                        hardModeBool.value = true;
                        clearMenu();
                    StartCoroutine(waitForStart());
        } else if (GameMode == 2) {
                        player.maxSpeed = 6f;
                        player.forwardSpeed = 5f;
                        transform.localScale = Vector3.zero;
                        expertModeBool.value = true;
                        clearMenu();
                    StartCoroutine(waitForStart());
        } 


   }

   public void pauseGame() {
       Time.timeScale = 0;
       mainScreenPanel.transform.localScale = new Vector3 (1, 1, 1);
       resume.transform.localScale = new Vector3 (1,1,1);
       endScene.transform.localScale = new Vector3 (1,1,1);
       pauseButton.transform.localScale = Vector3.zero;
       newSceneButton.transform.localScale = Vector3.zero;
       
   }

   public void OpenStore() {
       storePanel.transform.localScale = new Vector3 (1, 1, 1);
   }
   public void OpenCredits() {
       CreditPanel.transform.localScale = new Vector3 (1, 1, 1);
   }
   public void clearMenu() {
       mainScreenPanel.transform.localScale = Vector3.zero;
       startButton.transform.localScale = Vector3.zero;
       storeButton.transform.localScale = Vector3.zero;
       dropDownMenuGO.transform.localScale = Vector3.zero;
       
   }
       public void dropDownMenu() {
        var dropdownmenuComp = dropDownMenuGO.GetComponent<Dropdown>();
        int dropDownSelection = dropdownmenuComp.value;

        switch (dropDownSelection)
        {
            case 0:
            Debug.Log("Normal mode selected");
            GameMode = 0;
            PlayerPrefs.SetInt("GameModeSelection", 0);
            break;
            case 1:
            Debug.Log("hard mode");
            GameMode = 1;
            PlayerPrefs.SetInt("GameModeSelection", 1);
            break;
            case 2:
            Debug.Log("expert mode");
            GameMode = 2;
            PlayerPrefs.SetInt("GameModeSelection", 2);
            break;

            
        }

    }
   IEnumerator waitForStart() {
       yield return new WaitForSecondsRealtime(1);
       Time.timeScale = 1f;
   }

   public void birdMode() {
       SceneManager.LoadScene("MainScene");
   }
      public void restartNewScene() {
       SceneManager.LoadScene("NewScene");
   }


}
