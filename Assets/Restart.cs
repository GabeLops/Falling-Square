using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour
{
    public void restartgame()
    {
        SceneManager.LoadScene("_scenes");
    }


}
