using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject winTxt;
    public GameObject loseTxt;

    bool gameHasEnded = false;
    

    public void EndGame()
    {
        gameHasEnded = true;
        
        loseTxt.SetActive(true);
    }
    public void GameWin()
    {
        gameHasEnded = true;
        
        winTxt.SetActive(true);
        
    }
}
