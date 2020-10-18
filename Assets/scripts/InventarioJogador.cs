using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioJogador : MonoBehaviour
{
    public static int numKeys = 0;
    private string stringKeys;
    private GameObject text;

    void Start(){
    }

    void Update(){
        text = GameObject.Find("Text");
        text.GetComponent<TMPro.TextMeshProUGUI>().text = numKeys.ToString();
    }

}
