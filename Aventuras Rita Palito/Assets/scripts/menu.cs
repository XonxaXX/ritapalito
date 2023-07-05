using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string nomeCena;
    public GameObject MenuPanel; 
    // Start is called before the first frame update
    void Start()
    {
        //ativando painel menu
        MenuPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //funcao do botao start
    public void StartGame()
    {
        //carregando a cena game
        SceneManager.LoadScene(nomeCena);
    }
}
