using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Track : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public Button thisButton;
    public TMP_Text clipName;


    
    void Start()
    {
        clipName.text = clip.name;
        audioSource = FindObjectOfType<AudioSource>();
        
    }

    public void PlayTrack()
    {
        audioSource.clip = clip;
        audioSource.Play();
    }    
   
}
