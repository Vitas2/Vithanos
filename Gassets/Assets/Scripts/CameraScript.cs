using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class CameraScript : MonoBehaviour
{
    public float frente = 0;
    public float cima = 1;
    public float lado = -10;
    public float tempo = 0;
    public float x = 0;
    public float y = 0;
    public float z = 0;
    public float sensibilidade = 2.0f; //Controla a sensibilidade do mouse
    private float mouseX = 0.0f, mouseY = 0.0f; //Variáveis que controla a rotação do mouse
    public float velocidade = 5;
    public bool rodar = true, mover = true, tool = true;
    public Canvas mira, ferramentas;
 
    // Start is called before the first frame update
    void Start()
    {
        TrocaMira(rodar);
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            rodar = !rodar;
            TrocaMira(rodar);
        }
        if (Input.GetKeyDown("m"))
        {
            mover = !mover;
        }
        if (Input.GetKeyDown("t"))
        {
            tool = !tool;
            TrocaTool(tool);
        }


        if (rodar == true)
        {
            mouseX += Input.GetAxis("Mouse X") * sensibilidade; // Incrementa o valor do eixo X e multiplica pela sensibilidade
            mouseY -= Input.GetAxis("Mouse Y") * sensibilidade; // Incrementa o valor do eixo Y e multiplica pela sensibilidade. (Obs. usamos o - para inverter os valores)
            
            if (mouseY >= 90)
            mouseY = 89;
            if (mouseY <= -90)
            mouseY = -89;
            this.transform.eulerAngles = new Vector3(mouseY, mouseX, 0); //Executa a rotação da câmera de acordo com os eixos
        }
            
        if (mover == true)
        {
            if(Input.GetKey("w"))
            {
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    x = Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180)*Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    y = -Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    z = Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180)*Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    frente += 2*x;
                    cima += 2*y;
                    lado += 2*z;
                    this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,(float)lado);
                }
                else
                {
                    x = Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180)*Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    y = -Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    z = Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180)*Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    frente += x;
                    cima += y;
                    lado += z;
                    this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,(float)lado);
                }
            
            }
            if(Input.GetKey("s"))
            {
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    x = -Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180)*Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    y = Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    z = -Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180)*Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    frente += 2*x;
                    cima += 2*y;
                    lado += 2*z;
                    this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,(float)lado);
                }
                else
                {
                    x = -Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180)*Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    y = Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    z = -Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180)*Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.x*Mathf.PI/180)*Time.deltaTime*velocidade;
                    frente += x;
                    cima += y;
                    lado += z;
                    this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,(float)lado);
                }
            
            }
            if(Input.GetKey("a"))
            {
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    x = -Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180);
                    z = Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180);
                    frente += 2*x;
                    lado += 2*z;
                    this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,(float)lado);
                }
                else
                {
                    x = -Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180);
                    z = Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180);
                    frente += x;
                    lado += z;
                    this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,(float)lado);
                }
            }
            if(Input.GetKey("d"))
            {
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    x = Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180);
                    z = -Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180);
                    frente += 2*x;
                    lado += 2*z;
                    this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,(float)lado);
                }
                else
                {   
                    x = Mathf.Cos(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180);
                    z = -Mathf.Sin(this.GetComponent<Transform>().rotation.eulerAngles.y*Mathf.PI/180);
                    frente += x;
                    lado += z;
                    this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,(float)lado);
                }
                
            }
            if(this.GetComponent<Transform>().position.x > 250)
            {
                frente = 250;
                this.GetComponent<Transform>().position = new Vector3(250f,(float)cima,(float)lado);
            }
            if(this.GetComponent<Transform>().position.x < -250)
            {
                frente = -250;
                this.GetComponent<Transform>().position = new Vector3(-250f,(float)cima,(float)lado);
            }
            if(this.GetComponent<Transform>().position.y > 250)
            {
                cima = 250;
                this.GetComponent<Transform>().position = new Vector3((float)frente,250f,(float)lado);
            }
            if(this.GetComponent<Transform>().position.y < -250)
            {
                cima = -250;
                this.GetComponent<Transform>().position = new Vector3((float)frente,-250f,(float)lado);
            }
            if(this.GetComponent<Transform>().position.z > 250)
            {
                lado = 250;
                this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,250f);
            }
            if(this.GetComponent<Transform>().position.z < -250)
            {
                lado = -250;
                this.GetComponent<Transform>().position = new Vector3((float)frente,(float)cima,-250f);
            }
        }

    }
    void TrocaMira(bool rodar)
    {
        if(rodar == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            mira.enabled = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            mira.enabled = false;
        }
    }
    void TrocaTool(bool tool)
    {
        ferramentas.enabled = tool;
    }
}
