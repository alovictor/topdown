using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BowBehaviour : MonoBehaviour
{
    public float speed = 10f;
    public GameObject prefab;
    public GameObject wall;
    private GameObject arrow;
    private Vector3 pos_inicial;
    private Quaternion rot_inicial;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        pos_inicial = transform.position;
        rot_inicial = transform.rotation;
    }

    void Update(){
        if(arrow == null){
            arrow = Instantiate(prefab, pos_inicial, rot_inicial);
        }
        Collider2D wallcolider = wall.GetComponent<CompositeCollider2D>();
        Collider2D arrowcolider = arrow.GetComponent<BoxCollider2D>();
        Collider2D playercolider = player.GetComponent<BoxCollider2D>();

        if (wallcolider.IsTouching(arrowcolider)){
            Destroy(arrow);
        }
        if (arrowcolider.IsTouching(playercolider)){
            
        }
        else{
            arrow.transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        }
    }
}
