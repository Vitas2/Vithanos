using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ScriptEscolha : MonoBehaviour
{
    public Button espada;
    // Start is called before the first frame update
    void Start()
    {
        espada.onClick.AddListener(Espada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Espada()
    {
        SceneManager.LoadScene("SampleScene");
        SceneManager.UnloadScene("Escolha");
    }
}
