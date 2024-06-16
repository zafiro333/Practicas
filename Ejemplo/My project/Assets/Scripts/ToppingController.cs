using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToppingController : MonoBehaviour
{
    private TMP_Dropdown colorOptions;
    public Image top;
    public Sprite [] flavorsTop;

    void Start()
    {
       colorOptions = GetComponent<TMP_Dropdown>();
       top = GameObject.Find("Topping").GetComponent<Image>();

    }
    public void ChangeToppings()
    {
        switch (colorOptions.value)
        {
           case 0:
           top.sprite = flavorsTop[0];
           break;
           case 1:
           top.sprite = flavorsTop[1];
           break;
           case 2:
           top.sprite = flavorsTop[2];
           break;
        }
       
    }


}