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
    public TMP_Dropdown operacionDropdown; // Dropdown para seleccionar la operación

    void Start()
    {
        // Asigna el método Calcular al botón
        calcularButton.onClick.AddListener(Calcular);
    }

    public void Calcular()
    {
        float numero1;
        float numero2;

        // Validar y convertir los valores de los campos de entrada
        if (float.TryParse(primerNumero.text, out numero1) && float.TryParse(segundoNumero.text, out numero2))
        {
            float resultado = 0;
            switch (operacionDropdown.value)
            {
                case 0: // Suma
                    resultado = numero1 + numero2;
                    break;
                case 1: // Resta
                    resultado = numero1 - numero2;
                    break;
                case 2: // Multiplicación
                    resultado = numero1 * numero2;
                    break;
                case 3: // División
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Debug.LogError("No se puede dividir por cero.");
                        resultadoText.text = "Error: División por cero";
                        return;
                    }
                    break;
                default:
                    Debug.LogError("Operación no soportada.");
                    return;
            }
            resultadoText.text = resultado.ToString("F2"); // Mostrar el resultado con dos decimales
        }
        else
        {
            Debug.LogError("Entradas inválidas. Por favor, ingrese números válidos.");
        }
    }

    void Update()
    {
        
    }
}
