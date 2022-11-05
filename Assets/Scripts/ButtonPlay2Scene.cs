using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay2Scene : MonoBehaviour
{
    [SerializeField] private GameObject Left;
    [SerializeField] private GameObject Right;
    [SerializeField] private GameObject Up;
    [SerializeField] private GameObject Down;
    [SerializeField] private GameObject Restart;
    [SerializeField] private GameObject LVL;
    [SerializeField] private GameObject Play;
    [SerializeField] private GameObject Musik;
    [SerializeField] private GameObject Pause;
    [SerializeField] private GameObject SmokeOFF;

    private void Start()
    {
        Play.SetActive(false);
        Musik.SetActive(false);
        SmokeOFF.SetActive(false);
        Pause.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);
        Up.SetActive(true);
        Down.SetActive(true);
        Restart.SetActive(true);
        LVL.SetActive(true);
    }

   private void Update()
    {
        
    }

    public void OnClic()
    {
        Play.SetActive(false);
        Musik.SetActive(false);
        SmokeOFF.SetActive(false);
        Left.SetActive(true);
        Right.SetActive(true);
        Up.SetActive(true);
        Down.SetActive(true);
        Restart.SetActive(true);
        Pause.SetActive(true);
        LVL.SetActive(true);
    }

}
