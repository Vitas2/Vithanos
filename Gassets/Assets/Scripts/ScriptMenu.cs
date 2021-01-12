using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ScriptMenu : MonoBehaviour
{
    public Button btnInicia, btnSair;

    // Start is called before the first frame update
    void Start()
    {
        btnInicia.onClick.AddListener(Iniciar);
        btnSair.onClick.AddListener(Sair);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Iniciar()
    {
        SceneManager.LoadScene("Escolha");
        SceneManager.UnloadScene("Menu");
    }

    void Sair()
    {
        Application.Quit();
    }


}
