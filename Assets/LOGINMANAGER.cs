using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//CUANDO EL USUARIO PRESIONE EL BOTON ACEPTAR
//DEBE ESCRIBIRSE UN MENSAJE EN CONSOLA
//SI EL TEXTO DEL INPUTFIELD COINCIDE 
//CON UNA CONTRASEÑA PREDEFINIDA 
//ESCRIBIR ACCESS GRANTED, SINO ACCESS DENIED
public class LOGINMANAGER : MonoBehaviour
{
    public InputField input;
    string correct_pass = "a";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        Debug.Log(input.text);
        if(input.text == "a")
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}
