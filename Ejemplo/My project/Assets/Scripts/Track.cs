using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Track : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
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
        Reproductor.instance.currentTrack = idTrack;
    }    
   
}
