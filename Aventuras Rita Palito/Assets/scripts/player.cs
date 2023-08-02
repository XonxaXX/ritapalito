using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //variavel para o rigidbody
    private Rigidbody2D rig;
    //vector de posição inicial dp player
    private Vector3 posInicial;
    //variavel velocidade
    private float speed;

 
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(-3.31, -0.34, 0);
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
