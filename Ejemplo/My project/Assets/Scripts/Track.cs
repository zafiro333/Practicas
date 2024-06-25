using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


public class Track : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public Button thisButton;
    public TMP_Text clipName;
    public int idTrack;


    
    void Start()
    {
        try
        {
            clipName.text = clip.name;
            audioSource = FindObjectOfType<AudioSource>();
        }
        catch 
        { 
            Destroy(gameObject);
        }
        
        
    }

    public void PlayTrack()
    {
        audioSource.clip = clip;
        audioSource.Play();
    }    
   
}
