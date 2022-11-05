using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    public ParticleSystem SmokePerpl0;
    public ParticleSystem SmokePerpl1;
    public ParticleSystem SmokePerpl2;
    public ParticleSystem SmokePerpl3;
    
    void Start()
    {

    }

    
    void Update()
    {
        
    }

    public void OnClic()
    {
        SmokePerpl0.Play();
        SmokePerpl1.Play();
        SmokePerpl2.Play();
        SmokePerpl3.Play();
    }


    public void OnClicer()
    {
        SmokePerpl0.Stop();
        SmokePerpl1.Stop();
        SmokePerpl2.Stop();
        SmokePerpl3.Stop();
    }

}
