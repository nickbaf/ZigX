using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gStarted;

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
}
