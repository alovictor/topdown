using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUtilities : MonoBehaviour
{
    public GameObject ui;
    public GameObject menu;
    private PauseMenu pauseScript;
    public bool isPaused;

    void Awake(){
        ui.SetActive(true);
        InventarioJogador.numKeys = 0;
    }

    void Start(){
        pauseScript = menu.GetComponent<PauseMenu>();
    }

    void Update(){
        isPaused = PauseMenu.isPaused;
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                pauseScript.Continue();
            }
            else{
                pauseScript.Pause();
            }
        }
    }
}
