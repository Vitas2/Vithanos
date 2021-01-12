using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptBase : MonoBehaviour
{
    public GameObject canvasFe;
    // Start is called before the first frame update
    void Start()
    {
        canvasFe = GameObject.Find("CanvasFe");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Edit();
    }
    void Edit()
    {
        Debug.Log("Click");
        canvasFe.GetComponent<ScriptTools>().ActionSelect(GameObject.Find(this.name));
    }
}
