using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScriptScrollTool : MonoBehaviour
{
    public Scrollbar scr;
    public InputField x,y,z;
    
    // Start is called before the first frame update
    void Start()
    {
        scr.onValueChanged.AddListener(MudaValor);
    }

    
    void MudaValor(float valor)
    {
        
        if (ScriptTools.bmove == true)
        {
            if(ScriptTools.scrXYZ == "x")
            {
                 x.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value - 0.5f)*500f).ToString();
            }
            else if(ScriptTools.scrXYZ == "y")
            {
                y.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value - 0.5f)*500f).ToString();
            }
            else
            {
                z.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value - 0.5f)*500f).ToString();
            }
        } 
        else if (ScriptTools.broda == true)
        {
            if(ScriptTools.scrXYZ == "x")
            {
                 x.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value-0.5f)*180f+360).ToString();
            }
            else if(ScriptTools.scrXYZ == "y")
            {
                y.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value)*360f).ToString();
            }
            else
            {
                z.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value)*360f).ToString();
            }
        } 
        else if (ScriptTools.besca == true)
        {
            if(ScriptTools.scrXYZ == "x")
            {
                 x.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value)*500f).ToString();
            }
            else if(ScriptTools.scrXYZ == "y")
            {
                y.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value)*500f).ToString();
            }
            else
            {
                z.GetComponent<InputField>().text = ((scr.GetComponent<Scrollbar>().value)*500f).ToString();
            }
        } 

    }


}
