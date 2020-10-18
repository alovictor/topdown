using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollision : MonoBehaviour
{
    private GameObject player;
    private GameObject audioManager;
    
    void Awake(){
        player = GameObject.Find("Player");
        audioManager = GameObject.Find("AudioManager");
    }
    
    void Update(){

        if(player.GetComponent<BoxCollider2D>().IsTouching(gameObject.GetComponent<BoxCollider2D>())){
            InventarioJogador.numKeys++;
            audioManager.GetComponent<AudioManager>().Play("PegaChave");

            Destroy(gameObject);       
        }

    }
}   
