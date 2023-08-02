using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //variavel para o rigidbody
    private Rigidbody2D rig;
    //vector de posição inicial dp player
    private Vector3 posInicial;
    //variavel velocidade
    private float Speed = 5;

 
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(-3.3141f,-0.3481f,0f);
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(Speed, rig.velocity.y);
        rig.velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, rig.velocity.y);
        //verifica se a tecla a foi pressionada e o valor x da escala esta positivo
        if (Input.GetKeyDown(KeyCode.A) && transform.localScale.x > 0 )
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, 
                transform.localScale.y, transform.localScale.z);
            //Debug.Log("Tecla A pressionada");
        }
        //verifica se a tecla d foi pressionada e o valor x da escala esta negativo
        if (Input.GetKeyDown(KeyCode.D) && transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1,
                transform.localScale.y, transform.localScale.z);
            //Debug.Log("Tecla D pressionada");
        }



    }
}
