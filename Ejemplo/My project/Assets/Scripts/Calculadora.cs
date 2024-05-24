using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculadora : MonoBehaviour
{
    public TMP_InputField primerNumero;
    public TMP_InputField segundoNumero;
    public TMP_InputField resultado;

    public int resultado;
    // variables


    // Metodos
    public  void suma()
    {
        int numero1 = int.Parse(primerNumero.text);
        int numero2 = int.Parse(segundoNumero.text);

        resultado = numero1 + numero2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
