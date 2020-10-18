using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public float Speed = 10; // rapidez do movimento
    private Rigidbody2D rb;
    private InventarioJogador inv;
    private Vector3 change; // Vetor de movimentação com 3 dimensões
                            // (usei o vector3 pq a movimentação do rigidbody pede 3 dimensões,
                            // mas acho que deve ter um jeito melhor de fazer isso)
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        change = Vector3.zero; // inicializando o vetor de movimentação em (0, 0, 0) a cada update
        change.x = Input.GetAxis("Horizontal"); // modifico o X e o Y do change a partir do input (esquerda, direita, cima, baixo)
        change.y = Input.GetAxis("Vertical"); // aqui preferi usar o getaxisraw do que o getaxis mas n sei como explicar
                                                 // por aqui então depois me lembra de te explicar isso se tu quiser
 
        if(change != Vector3.zero)
        {
            MoveCharacter(); // movimento propriamente dito
        }
        
    }

    void MoveCharacter()
    {   
        rb.MovePosition((transform.position + change.normalized * Speed * Time.deltaTime)); //movimento levando em consideração rapidez e framerate
    }
}