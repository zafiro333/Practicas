using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MedioController : MonoBehaviour
{
    private TMP_Dropdown colorOptions;
    public Image medio;
    public Sprite [] flavorsMedio;

    void Start()
    {
       colorOptions = GetComponent<TMP_Dropdown>();
       medio = GameObject.Find("MedioPastel").GetComponent<Image>();

    }
    public void ChangeMedio()
    {
        switch (colorOptions.value)
        {
           case 0:
           medio.sprite = flavorsMedio[0];
           break;
           case 1:
           medio.sprite = flavorsMedio[1];
           break;
           case 2:
           medio.sprite = flavorsMedio[2];
           break;
        }
       
    }


}