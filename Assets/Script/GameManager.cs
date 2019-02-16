using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public bool gStarted;
    public Text scoreText;

    public int score = 0;




    public void StartGame()
    {

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
    }

}
