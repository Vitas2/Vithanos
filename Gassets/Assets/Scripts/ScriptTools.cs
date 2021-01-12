using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScriptTools : MonoBehaviour
{
    public Button btnSelect, btnMove, btnRoda, btnEsca, btnAdd, btnDown, btnsrcXYZ;
    public static bool bselect = true, bmove = false, broda = false, besca = false, badd = false, bdown = false,btoolaux=false; 
    public GameObject gmoSelecionado = null, pnlTool,pnlToolAux;
    public InputField x, y, z;
    public Image imgTool;
    public Sprite clickSelect,clickMove,clickRoda,clickEsca,Normal;
    public Scrollbar scroll;
    public Text lblXYZ;
    public static string scrXYZ = "x";
    
    // Start is called before the first frame update
    void Start()
    {
       pnlToolAux.SetActive(false);
       btnSelect.onClick.AddListener(Seleciona);
       btnMove.onClick.AddListener(Movimenta);
       btnRoda.onClick.AddListener(Rotaciona);
       btnEsca.onClick.AddListener(Escalona);
       scroll.enabled = false;
       btnAdd.onClick.AddListener(Adiciona);
       btnDown.onClick.AddListener(Baixa);
       pnlTool.SetActive(false);
       x.onValueChanged.AddListener(MudaX);
       y.onValueChanged.AddListener(MudaY);
       z.onValueChanged.AddListener(MudaZ);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            try
            {
                if(scrXYZ == "x")
                {
                    scrXYZ = "y";
                }
                else if(scrXYZ == "y")
                {
                    scrXYZ = "z";
                }
                else          
                {
                    scrXYZ = "x";
                }
                lblXYZ.GetComponent<Text>().text = scrXYZ;
               
            }
            catch(Exception e)
            {}
             if(btoolaux == true)
                {
                    if(bmove == true)
                    {
                        if(scrXYZ == "x")
                        {
                            scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text))/500f)+0.5f;
                        }
                        if(scrXYZ == "y")
                        {
                            scroll.GetComponent<Scrollbar>().value = ((float.Parse(y.GetComponent<InputField>().text))/500f)+0.5f;
                        }
                        if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = ((float.Parse(z.GetComponent<InputField>().text))/500f)+0.5f;
                        }
                    }
                    else if(broda == true)
                    {
                        if(scrXYZ == "x")
                        {
                            
                             if(float.Parse(x.GetComponent<InputField>().text) >= 270)
                            {
                                scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text)-270)/180);
                            }
                            else if(float.Parse(x.GetComponent<InputField>().text) <= 90)
                            {
                                scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text)+90)/180);
                            }
                            

                        }
                        else if(scrXYZ == "y")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(y.GetComponent<InputField>().text)/360f;
                        }
                        else if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(z.GetComponent<InputField>().text)/360f;
                        }
                    }
                    else if(besca == true)
                    {
                        if(scrXYZ == "x")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(x.GetComponent<InputField>().text)/500f;
                        }
                        else if(scrXYZ == "y")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(y.GetComponent<InputField>().text)/500f;
                        }
                        else if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(z.GetComponent<InputField>().text)/500f;
                        }
                    }

                }
            
        }
        if (Input.GetKeyDown("b"))
        {
             if(bmove==true || besca==true || broda==true)
            {
                btoolaux=!btoolaux;
                scroll.enabled= !scroll.enabled;
                //btnsrcXYZ.enabled= !btnsrcXYZ.enabled;
                pnlToolAux.SetActive(btoolaux);
            }
            if(btoolaux == true)
                {
                    if(bmove == true)
                    {
                        if(scrXYZ == "x")
                        {
                            scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text))/500f)+0.5f;
                        }
                        if(scrXYZ == "y")
                        {
                            scroll.GetComponent<Scrollbar>().value = ((float.Parse(y.GetComponent<InputField>().text))/500f)+0.5f;
                        }
                        if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = ((float.Parse(z.GetComponent<InputField>().text))/500f)+0.5f;
                        }
                    }
                    else if(broda == true)
                    {
                        if(scrXYZ == "x")
                        {
                           
                            if(float.Parse(x.GetComponent<InputField>().text) >= 270)
                            {
                                scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text)-270)/180);
                            }
                            else if(float.Parse(x.GetComponent<InputField>().text) <= 90)
                            {
                                scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text)+90)/180);
                            }
                            

                        }
                        else if(scrXYZ == "y")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(y.GetComponent<InputField>().text)/360f;
                        }
                        else if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(z.GetComponent<InputField>().text)/360f;
                        }
                    }
                    else if(besca == true)
                    {
                        if(scrXYZ == "x")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(x.GetComponent<InputField>().text)/500f;
                        }
                        else if(scrXYZ == "y")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(y.GetComponent<InputField>().text)/500f;
                        }
                        else if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(z.GetComponent<InputField>().text)/500f;
                        }
                    }

                }
        }
        if (Input.GetKey("up"))
        {
            if(gmoSelecionado!=null)
            {
                if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    if(besca==true || bmove==true)
                    {
                    
                        ViaTeclado(10);
                        
                    }
                    else if(broda==true)
                    {
                        ViaTeclado(1.5f);
                    }
                }
                else
                {
                    if(besca==true || bmove==true)
                    {
                    
                        ViaTeclado(2);
                        
                    }
                    else if(broda==true)
                    {
                        ViaTeclado(1);
                    }
                }
                
            }
             
        }
        if (Input.GetKey("down"))
        {
            if(gmoSelecionado!=null)
            {
                if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    if(besca==true || bmove==true)
                    {
                    
                        ViaTeclado(-10);
                        
                    }
                    else if(broda==true)
                    {
                        ViaTeclado(-1.5f);
                    }
                }
                else
                {
                    if(besca==true || bmove==true)
                    {
                    
                        ViaTeclado(-2);
                        
                    }
                    else if(broda==true)
                    {
                        ViaTeclado(-1);
                    }
                }
              
            }
        }
    }
    void Seleciona()
    {
        funcLoka(1);
        imgTool.GetComponent<Image>().sprite= clickSelect;
    }
    void Movimenta()
    {
        imgTool.GetComponent<Image>().sprite= clickMove;
        funcLoka(2);
        x.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().position.x).ToString();
        y.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().position.y).ToString();
        z.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().position.z).ToString();
    }
    void Rotaciona()
    {
        imgTool.GetComponent<Image>().sprite= clickRoda;
        funcLoka(3);
        x.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().eulerAngles.x).ToString();
        y.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().eulerAngles.y).ToString();
        z.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().eulerAngles.z).ToString();
    }
    void Escalona()
    {
        imgTool.GetComponent<Image>().sprite= clickEsca;
        funcLoka(4);
        x.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().localScale.x).ToString();
        y.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().localScale.y).ToString();
        z.GetComponent<InputField>().text = (gmoSelecionado.GetComponent<Transform>().localScale.z).ToString();
    }
    void ViaTeclado(float auxVT)
    {
        
        if(bmove)
        {
            if(scrXYZ=="x")
            {
                MudaX((gmoSelecionado.transform.position.x + (auxVT)).ToString());
            }
            else if(scrXYZ=="y")
            {
                MudaY((gmoSelecionado.transform.position.y + (auxVT)).ToString()); 
            }
            else
            {
                MudaZ((gmoSelecionado.transform.position.z + (auxVT)).ToString()); 
            }   
        }    
        else if(broda)
        {
            if(scrXYZ=="x")
            {
               MudaX(((gmoSelecionado.transform.eulerAngles.x + auxVT)).ToString());
            }
            else if(scrXYZ=="y")
            {
               MudaY(((gmoSelecionado.transform.eulerAngles.y + auxVT)).ToString()); 
            }
            else
            {
                MudaZ(((gmoSelecionado.transform.eulerAngles.z + auxVT)).ToString()); 
            }   
        }
        else if(besca)
        {
            if(scrXYZ=="x")
            {
               MudaX(((gmoSelecionado.transform.localScale.x + auxVT)).ToString());
            }
            else if(scrXYZ=="y")
            {
               MudaY(((gmoSelecionado.transform.localScale.y + auxVT)).ToString()); 
            }
            else
            {
                MudaZ(((gmoSelecionado.transform.localScale.z + auxVT)).ToString()); 

            }   
        }
    
        

    }
    void Adiciona()
    {
        funcLoka(5); 
    }
    void Baixa()
    {
       funcLoka(6);
    }
    void funcLoka(int a)
    {
        bselect = false; bmove = false; broda = false; besca = false; badd = false; bdown = false;
        if(a==1)
        {
            bselect=true;
            //btnsrcXYZ.enabled=false;
            pnlTool.SetActive(false);
            pnlToolAux.SetActive(false);
        }
        else if(a==2)
        {
            bmove=true;
            pnlTool.SetActive(true);
           
        }
        else if(a==3)
        {
            broda= true;
            pnlTool.SetActive(true);
        }
        else if(a==4)
        {
            besca = true;
            pnlTool.SetActive(true);
        }
        else if(a==5)
        {
            badd =true;
            //btnsrcXYZ.enabled=false;
            pnlTool.SetActive(false);
            pnlToolAux.SetActive(false);
        }
        else if(a==6)
        {
            bdown=true;
            //btnsrcXYZ.enabled=false;
            pnlTool.SetActive(false);
            pnlToolAux.SetActive(false);
        }
        
           
            
            
        

    }

    public void ActionSelect(GameObject eae)
    {
        gmoSelecionado=eae;
        Debug.Log(gmoSelecionado.name);

        if(btoolaux == true)
        {
            
            if(bmove == true)
            {
                if(scrXYZ == "x")
                {
                    scroll.GetComponent<Scrollbar>().value = ((gmoSelecionado.transform.position.x)/500f)+0.5f;
                }
                if(scrXYZ == "y")
                {
                    scroll.GetComponent<Scrollbar>().value = ((gmoSelecionado.transform.position.y)/500f)+0.5f;
                }
                if(scrXYZ == "z")
                {
                    scroll.GetComponent<Scrollbar>().value = ((gmoSelecionado.transform.position.z)/500f)+0.5f;
                }
            }
            else if(broda == true)
            {
                if(scrXYZ == "x")
                    {                   
                        if(gmoSelecionado.transform.eulerAngles.x >= 270)
                    {
                        scroll.GetComponent<Scrollbar>().value = ((gmoSelecionado.transform.eulerAngles.x-270)/180);
                    }
                    else if(gmoSelecionado.transform.eulerAngles.x <= 90)
                    {
                        scroll.GetComponent<Scrollbar>().value = ((gmoSelecionado.transform.eulerAngles.x+90)/180);
                    }
                    

                }
                else if(scrXYZ == "y")
                {
                    scroll.GetComponent<Scrollbar>().value = gmoSelecionado.transform.eulerAngles.y/360f;
                }
                else if(scrXYZ == "z")
                {
                    scroll.GetComponent<Scrollbar>().value = gmoSelecionado.transform.eulerAngles.z/360f;
                }
            }
            else if(besca == true)
            {
                if(scrXYZ == "x")
                {
                    scroll.GetComponent<Scrollbar>().value = gmoSelecionado.transform.localScale.x/500f;
                }
                else if(scrXYZ == "y")
                {
                    scroll.GetComponent<Scrollbar>().value = gmoSelecionado.transform.localScale.y/500f;
                }
                else if(scrXYZ == "z")
                {
                    scroll.GetComponent<Scrollbar>().value = gmoSelecionado.transform.localScale.z/500f;
                }
            }

        }



    }
    public void MudaX(string s)
    {
        float f;
        try
        {
            
            f = float.Parse(s);
            f = (float)Math.Round(f,1);
            
            if(gmoSelecionado != null)
            {
                if(bmove==true)
                {
                    if (f <= (250-(gmoSelecionado.GetComponent<Transform>().localScale.x/2)) && f>=(-250+(gmoSelecionado.GetComponent<Transform>().localScale.x/2)))
                    {
                        gmoSelecionado.GetComponent<Transform>().position= new Vector3(f,gmoSelecionado.GetComponent<Transform>().position.y,gmoSelecionado.GetComponent<Transform>().position.z);
                        x.GetComponent<InputField>().text=(f).ToString();
                    }     
                    else
                    {
                        if(f > 0)
                        {
                            float au=250-(gmoSelecionado.GetComponent<Transform>().localScale.x/2);
                            x.GetComponent<InputField>().text=(au).ToString();
                            //gmoSelecionado.GetComponent<Transform>().position= new Vector3(250-(gmoSelecionado.GetComponent<Transform>().localScale.x/2),gmoSelecionado.GetComponent<Transform>().position.y,gmoSelecionado.GetComponent<Transform>().position.z);
                        }
                        else
                        {
                            float au=-250+(gmoSelecionado.GetComponent<Transform>().localScale.x/2);
                            x.GetComponent<InputField>().text=(au).ToString();
                            //gmoSelecionado.GetComponent<Transform>().position= new Vector3(-250+(gmoSelecionado.GetComponent<Transform>().localScale.x/2),gmoSelecionado.GetComponent<Transform>().position.y,gmoSelecionado.GetComponent<Transform>().position.z);
                        } 
                    }

                    if(btoolaux == true)
                    {
                        if(scrXYZ == "x")
                        {
                            scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text))/500f)+0.5f;
                        }
                    }


                }
                else if(broda==true)
                {
            
                    gmoSelecionado.GetComponent<Transform>().eulerAngles= new Vector3(f%360,gmoSelecionado.GetComponent<Transform>().eulerAngles.y,gmoSelecionado.GetComponent<Transform>().eulerAngles.z);
                    x.GetComponent<InputField>().text=((f)%360).ToString();

                    if(btoolaux == true)
                    {
                        if(scrXYZ == "x")
                        {
                            if(float.Parse(x.GetComponent<InputField>().text) >= 270)
                            {
                                scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text)-270)/180);
                            }
                            else if(float.Parse(x.GetComponent<InputField>().text) <= 90)
                            {
                                scroll.GetComponent<Scrollbar>().value = ((float.Parse(x.GetComponent<InputField>().text)+90)/180);
                            }
                        }
                    }

                }
                else if(besca)
                {
                    if ((f)<=500 && (f)>0)
                    {
                        gmoSelecionado.GetComponent<Transform>().localScale=new Vector3(f,gmoSelecionado.GetComponent<Transform>().localScale.y,gmoSelecionado.GetComponent<Transform>().localScale.z);
                        x.GetComponent<InputField>().text=(f).ToString();
                    }     
                    else
                    {
                        x.GetComponent<InputField>().text="1";                  
                        
                    }

                    if(btoolaux == true)
                    {
                        if(scrXYZ == "x")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(x.GetComponent<InputField>().text)/500f;
                        }
                    }
                    


                }
            
            }
       
        }
        catch(Exception e)
        {
            x.GetComponent<InputField>().text="0";
        }     
    }
    public void MudaY(string s)
    {
        float f;
        try 
        {
            f=float.Parse(s);
            f= (float)Math.Round(f,1);
            if(gmoSelecionado != null)
            {
                if(bmove)
                {
                        if (f <= (250-(gmoSelecionado.GetComponent<Transform>().localScale.y/2)) && f>=(-250+(gmoSelecionado.GetComponent<Transform>().localScale.y/2)))
                        {
                            gmoSelecionado.GetComponent<Transform>().position= new Vector3(gmoSelecionado.GetComponent<Transform>().position.x,f,gmoSelecionado.GetComponent<Transform>().position.z);
                            y.GetComponent<InputField>().text=(f).ToString();
                        }     
                        else
                        {
                            if(f > 0)
                            {
                                float au=250-(gmoSelecionado.GetComponent<Transform>().localScale.y/2);
                                y.GetComponent<InputField>().text=(au).ToString();
                                //gmoSelecionado.GetComponent<Transform>().position= new Vector3(250-(gmoSelecionado.GetComponent<Transform>().localScale.x/2),gmoSelecionado.GetComponent<Transform>().position.y,gmoSelecionado.GetComponent<Transform>().position.z);
                            }
                            else
                            {
                                float au=-250+(gmoSelecionado.GetComponent<Transform>().localScale.y/2);
                                y.GetComponent<InputField>().text=(au).ToString();
                                //gmoSelecionado.GetComponent<Transform>().position= new Vector3(-250+(gmoSelecionado.GetComponent<Transform>().localScale.x/2),gmoSelecionado.GetComponent<Transform>().position.y,gmoSelecionado.GetComponent<Transform>().position.z);
                            } 
                        }
                        if(btoolaux == true)
                        {
                            if(scrXYZ == "y")
                            {
                                scroll.GetComponent<Scrollbar>().value = ((float.Parse(y.GetComponent<InputField>().text))/500f)+0.5f;
                            }
                        }      
                }
                else if(broda==true)
                {
            
                    gmoSelecionado.GetComponent<Transform>().eulerAngles= new Vector3(gmoSelecionado.GetComponent<Transform>().eulerAngles.x,f%360,gmoSelecionado.GetComponent<Transform>().eulerAngles.z);
                    y.GetComponent<InputField>().text=((f)%360).ToString();    


                    if(btoolaux == true)
                    {
                        if(scrXYZ == "y")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(y.GetComponent<InputField>().text)/360f;
                        }
                    }

                }
                 else if(besca)
                {
                    if ((f)<=500 && (f)>0)
                    {
                        gmoSelecionado.GetComponent<Transform>().localScale=new Vector3(gmoSelecionado.GetComponent<Transform>().localScale.x,f,gmoSelecionado.GetComponent<Transform>().localScale.z);
                        y.GetComponent<InputField>().text=(f).ToString();
                    }     
                    else
                    {
                        y.GetComponent<InputField>().text="1";
                    } 

                    if(btoolaux == true)
                    {
                        if(scrXYZ == "y")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(y.GetComponent<InputField>().text)/500f;
                        }
                    }


                }

            }
        }
        catch(Exception e)
        {
            y.GetComponent<InputField>().text="0";
        }
        
        
    }
    public void MudaZ(string s)
    {
        float f;
        try
        {
            f=float.Parse(s);
            f = (float)Math.Round(f,1);
            if(gmoSelecionado != null)
            {
                if(bmove)
                {
                    if (f <= (250-(gmoSelecionado.GetComponent<Transform>().localScale.z/2)) && f>=(-250+(gmoSelecionado.GetComponent<Transform>().localScale.z/2)))
                    {
                        gmoSelecionado.GetComponent<Transform>().position= new Vector3(gmoSelecionado.GetComponent<Transform>().position.x,gmoSelecionado.GetComponent<Transform>().position.y,f);
                         z.GetComponent<InputField>().text=(f).ToString();
                    }     
                    else
                    {
                        if(f > 0)
                        {
                            float au=250-(gmoSelecionado.GetComponent<Transform>().localScale.z/2);
                            z.GetComponent<InputField>().text=(au).ToString();
                            //gmoSelecionado.GetComponent<Transform>().position= new Vector3(250-(gmoSelecionado.GetComponent<Transform>().localScale.x/2),gmoSelecionado.GetComponent<Transform>().position.y,gmoSelecionado.GetComponent<Transform>().position.z);
                        }
                        else
                        {
                            float au=-250+(gmoSelecionado.GetComponent<Transform>().localScale.z/2);
                            z.GetComponent<InputField>().text=(au).ToString();
                            //gmoSelecionado.GetComponent<Transform>().position= new Vector3(-250+(gmoSelecionado.GetComponent<Transform>().localScale.x/2),gmoSelecionado.GetComponent<Transform>().position.y,gmoSelecionado.GetComponent<Transform>().position.z);
                        } 
                    }
                    if(btoolaux == true)
                    {
                        if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = ((float.Parse(z.GetComponent<InputField>().text))/500f)+0.5f;
                        }
                    } 
                }
                else if(broda==true)
                {
                    
                    gmoSelecionado.GetComponent<Transform>().eulerAngles= new Vector3(gmoSelecionado.GetComponent<Transform>().eulerAngles.x,gmoSelecionado.GetComponent<Transform>().eulerAngles.y,f%360);
                    z.GetComponent<InputField>().text=((f)%360).ToString();

                    if(btoolaux == true)
                    {
                        if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(z.GetComponent<InputField>().text)/360f;
                        }
                    }



                }
                else if(besca)
                {
                    if ((f)<=500 && (f)>0)
                    {
                        gmoSelecionado.GetComponent<Transform>().localScale=new Vector3(gmoSelecionado.GetComponent<Transform>().localScale.x,gmoSelecionado.GetComponent<Transform>().localScale.y,f);
                        z.GetComponent<InputField>().text=(f).ToString();
                    }     
                    else
                    {
                        z.GetComponent<InputField>().text="1";
                    } 

                   if(btoolaux == true)
                    {
                        if(scrXYZ == "z")
                        {
                            scroll.GetComponent<Scrollbar>().value = float.Parse(z.GetComponent<InputField>().text)/500f;
                        }
                    }


                }
            }
           
        }
        catch (Exception e)
        {
            z.GetComponent<InputField>().text="0";
        }
    }
}
