using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenúInicial : MonoBehaviour
{
    public void Calculadora()
    {
        SceneManager.LoadScene("Calculadora");
    }
    public void IS()
    {
        SceneManager.LoadScene("IS");
    }
    public void ReproductorMúsica()
    {
        SceneManager.LoadScene("ReproductorMúsica");
    }
    public void RepVideo()
    {
        SceneManager.LoadScene("RepVideo");
    }
    public void SelecciónPastel()
    {
        SceneManager.LoadScene("SelecciónPastel");
    }
    public void Regresar()
    {
        SceneManager.LoadScene("MenúPrincipal");
    }

}
