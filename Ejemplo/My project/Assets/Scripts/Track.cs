using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Track : MonoBehaviour
{
    public AudioClip clip;
    public TMP_Text clipName;


    
    void Start()
    {
        clipName.text = clip.name;
    }

   
}
