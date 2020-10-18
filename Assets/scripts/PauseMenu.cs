using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public void Pause(){
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        isPaused = true;
    }
    public void Continue(){
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        isPaused = false;
    }

    public void Options(){

    }

    public void Exit(){
        SceneManager.LoadScene(0);
    }
}
