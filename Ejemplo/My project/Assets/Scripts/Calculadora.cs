using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculadora : MonoBehaviour
{
    public TMP_InputField primerNumero;
    public TMP_InputField segundoNumero;
    public TMP_InputField resultadoInput; // Renombrar para evitar conflicto de nombres

    private int resultado; // Variable interna para almacenar el resultado

    // Metodos
    public void Suma()
    {
        int numero1;
        int numero2;

        // Validar y convertir los valores de los campos de entrada
        if (int.TryParse(primerNumero.text, out numero1) && int.TryParse(segundoNumero.text, out numero2))
        {
            resultado = numero1 + numero2;
            resultadoInput.text = resultado.ToString(); // Mostrar el resultado en el campo de texto
        }
        else
        {
            Debug.LogError("Entradas inválidas. Por favor, ingrese números válidos.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
