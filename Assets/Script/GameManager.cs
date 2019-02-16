using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public bool gStarted;
    public Text scoreText;
    public Text HighScoreText;

    public int score = 0;

    private void Awake()
    {
        HighScoreText.text = "High Score: " + getHighScore().ToString();
    }


    public void StartGame()
    {
        FindObjectOfType<road>().StartBuilding();
        gStarted = true;
    }



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartGame();
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public void increaseScore() {

        score++;
        scoreText.text = score.ToString();
        if (score > getHighScore())
        {
            PlayerPrefs.SetInt("HighScore", score);
            HighScoreText.text = "High Score: " + score.ToString(); 
        }
    }

    public int getHighScore()
    {
        int i = PlayerPrefs.GetInt("HighScore");
        return i;
    }

}
