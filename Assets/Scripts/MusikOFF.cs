using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikOFF : MonoBehaviour
{
    [SerializeField] private GameObject MusikLine;
    private void Start()
    {
        MusikLine.SetActive(false);
    }


   private void Update()
    {
          
    }

    public void OnClic()
    {
        MusikLine.SetActive(true);
    }

    public void OnCic()
    {
        MusikLine.SetActive(false);
    }

}
