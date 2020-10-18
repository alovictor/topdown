using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private GameObject player;
    private Collider2D fim;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        fim = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(fim.IsTouching(player.GetComponent<BoxCollider2D>())){
            if(InventarioJogador.numKeys == 3){
                SceneManager.LoadScene("Game");
            }
        }
    }
}
