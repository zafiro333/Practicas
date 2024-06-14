using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Arreglos : MonoBehaviour
{
    public GameObject panelAlertas;
    public string[] textoAlertas; 

    public List<string>usuarios = new List<string>();
    
    public TMP_InputField nombreUsuario;
    public TMP_Text alertasDisplay;

    // Start is called before the first frame update
    void Start()
    {
        usuarios.Add(item:"Zafiro");
        usuarios.Add(item:"Baz");
        usuarios.Add(item:"Will");
    }

    public void AccederConUsuario()
    {
        if(usuarios.Contains(nombreUsuario.text))
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[0];
        }
        else
        {
            panelAlertas.SetActive(true);
            alertasDisplay.text = textoAlertas[1];
        }
    }

    
}
