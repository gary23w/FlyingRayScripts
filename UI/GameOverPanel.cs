using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class GameOverPanel : MonoBehaviour
{
    public FloatVariable score;

    public FloatVariable highScore;

    public FloatVariable hardHighscore;
    public FloatVariable expertHighScore;

    public FloatVariable lightCollected;

    public int adcount;

    public BoolVariable playerAlive;

    public BoolVariable hardModeBool;

    public GameObject hardModeEnabledText;

    public BoolVariable expertModeBool;
    public GameObject expertModeEnabledText;

    public Image medalImage;

    public Sprite bronzeStar;

    public Sprite silverStar;

    public Sprite goldStar;

    public GameObject pauseButton;

    public int goldMinScore;

    public int silverMinScore;


    public Text newHighScoreLabel;
    public Text newHighScoreLabelHard;
    public Text newHighScoreLabelExpert;
    bool visible;
    string gameId = "3776473";
    bool testMode = false;

    private void Awake() {
        Advertisement.Initialize (gameId, testMode); 
        transform.localScale = Vector3.zero;
        try{
             newHighScoreLabelExpert.transform.localScale = Vector3.zero;
                newHighScoreLabelHard.transform.localScale = Vector3.zero;
        } catch {
            Debug.Log("Must Be in Bird Mode");
        }

        score.SetValue(0);
        if(PlayerPrefs.HasKey("HighScore")) {
            highScore.value = PlayerPrefs.GetFloat("HighScore");
        } else {
            PlayerPrefs.SetFloat("HighScore", 0);
        }
        /// HARD MODE
          if(PlayerPrefs.HasKey("HighScoreHardMode")) {
            hardHighscore.value = PlayerPrefs.GetFloat("HighScoreHardMode");
        } else {
            PlayerPrefs.SetFloat("HighScoreHardMode", 0);
        }
        // EXPERT MODE
        if(PlayerPrefs.HasKey("HighScoreExpertMode")) {
            expertHighScore.value = PlayerPrefs.GetFloat("HighScoreExpertMode");
        } else {
            PlayerPrefs.SetFloat("HighScoreExpertMode", 0);
        }
    
    }
    void FixedUpdate()
    {
        if(playerAlive.value == true) {
            if(Time.timeScale > 0f) {
                score.ApplyChange(Time.deltaTime * 100);
            }
        } else if (visible != true) {
            GameOver();
            pauseButton.transform.localScale = Vector3.zero;
        }
    }

    void GameOver() {
        visible = true;
        

        Time.timeScale = 0f;
 

        if(score.value > goldMinScore) {
            medalImage.sprite = goldStar;
            lightCollected.value += 50;
        } else if (score.value > silverMinScore) {
            medalImage.sprite = silverStar;
            lightCollected.value += 40;
        } else {
            medalImage.sprite = bronzeStar;
            lightCollected.value += 10;

        }

        if(score.value < highScore.value) {
            newHighScoreLabel.transform.localScale = Vector3.zero;
        } else {
            highScore.SetValue(score.value);
            PlayerPrefs.SetFloat("HighScore", score.value);
        }
        if(hardModeBool.value == true) {
            hardModeEnabledText.transform.localScale = new Vector3(1,1,1);
            hardModeBool.value = false; 

        if(score.value > hardHighscore.value) {
                    newHighScoreLabelHard.transform.localScale = new Vector3(1,1,1);
                    hardHighscore.SetValue(score.value);
                    PlayerPrefs.SetFloat("HighScoreHardMode", score.value);
            }
        } 
      
        if (expertModeBool.value == true) {
            expertModeEnabledText.transform.localScale = new Vector3(1,1,1);
            expertModeBool.value = false;

        if(score.value > expertHighScore.value) {
                newHighScoreLabelExpert.transform.localScale = new Vector3(1,1,1);
                expertHighScore.SetValue(score.value);
                PlayerPrefs.SetFloat("HighScoreExpertMode", score.value);
           }
        }
     
        transform.localScale = Vector3.one;

    }
    public void ReloadScene() {
        adcount = PlayerPrefs.GetInt("ADCOUNT");
        adcount++;
        PlayerPrefs.SetInt("ADCOUNT", adcount);
        if(adcount == 5) {
            Advertisement.Show();
        } else if (adcount == 6) {
            PlayerPrefs.SetInt("ADCOUNT", 0);
        }
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log(adcount.ToString());
            pauseButton.transform.localScale = new Vector3 (1, 1, 1);
    }

}
