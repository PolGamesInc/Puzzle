using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] private GameObject[] FirstGroup;
    [SerializeField] private GameObject[] SecondGroup;
    [SerializeField] private Activator Button;
    [SerializeField] private Material Normal;
    [SerializeField] private Material Transparent;



    private void OnTriggerEnter(Collider other)
    {
        
        

            if (other.CompareTag("cub") || other.CompareTag("Player"))
            {
                foreach (GameObject first in FirstGroup)
                {
                    first.GetComponent<Renderer>().material = Normal;
                    first.GetComponent<Collider>().isTrigger = false;
                }

                foreach (GameObject Second in SecondGroup)
                {
                 Second.GetComponent<Renderer>().material = Transparent;
                    Second.GetComponent<Collider>().isTrigger = true;
                }
                GetComponent<Renderer>().material = Transparent;
                Button.GetComponent<Renderer>().material = Normal;
            }
    }

}

