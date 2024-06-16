using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlavorController : MonoBehaviour
{
    private TMP_Dropdown colorOptions;
    public Image pastel;
    public Sprite [] flavorsBase;

    void Start()
    {
       colorOptions = GetComponent<TMP_Dropdown>();
       pastel = GameObject.Find("Pastel").GetComponent<Image>();

    }
    public void ChangeFlavor()
    {
        switch (colorOptions.value)
        {
           case 0:
           pastel.sprite = flavorsBase[0];
           break;
           case 1:
           pastel.sprite = flavorsBase[1];
           break;
           case 2:
           pastel.sprite = flavorsBase[2];
           break;
        }
       
    }


}
