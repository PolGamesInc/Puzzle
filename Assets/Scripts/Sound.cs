using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource Audio;
    [SerializeField] private AudioClip Button;
    void Start() 
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnClic()
    {
        Audio.clip = Button;
        Audio.Play();
    }

}
