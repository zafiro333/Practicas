using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBeta : MonoBehaviour

{
    public GameObject logo;
    public GameObject popUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickEnBotonPulsar()
    {
        Debug.Log("Se ha pulsado el botón.");
        //logo.SetActivate(false);
    }
    public void MostrarPopUp()
    {
        popUp.SetActive(true);
    }
    public void OcultarPopUp()
    {
        popUp.SetActive(false);
    }
}
