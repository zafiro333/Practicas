using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{
    public AudioSource repAudio;
    public List<AudioClip> album_01 = new List<AudioClip>();
    public Transform trackContainer;
    public GameObject trackObj;

    
    void Start()
    {
       for (int i = 0; i < album_01.Count; i++)
        {
            Instantiate(trackObj, trackContainer);
            trackObj.GetComponent<Track>().clip = album_01[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
