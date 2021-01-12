using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preload : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.UnloadScene("SampleScene");
        SceneManager.UnloadScene("Escolha");
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
