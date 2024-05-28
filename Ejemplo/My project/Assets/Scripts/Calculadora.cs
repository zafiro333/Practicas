using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Calculadora : MonoBehaviour
{
    public TMP_InputField primerNumero;
    public TMP_InputField segundoNumero;
    public TextMeshProUGUI resultadoText; // Campo de texto para mostrar el resultado
    public Button calcularButton; // Botón para calcular

    // Métodos
    void Start()
    {
        // Asigna el método Suma al botón
        calcularButton.onClick.AddListener(Suma);
    }

    public void Suma()
    {
        int numero1;
        int numero2;

        // Validar y convertir los valores de los campos de entrada
        if (int.TryParse(primerNumero.text, out numero1) && int.TryParse(segundoNumero.text, out numero2))
        {
            int resultado = numero1 + numero2;
            resultadoText.text = resultado.ToString(); // Mostrar el resultado en el campo de texto
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
