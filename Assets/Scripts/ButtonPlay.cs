using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
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
        Left.SetActive(false);
        Right.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);
        Restart.SetActive(false);
        LVL.SetActive(false);
    }

    private void Update()
    {
        
    }

    public void OnClic()
    {
        Left.SetActive(true);
        Right.SetActive(true);
        Up.SetActive(true);
        Down.SetActive(true);
        Restart.SetActive(true);
        LVL.SetActive(true);
        SmokeOFF.SetActive(false);
        Play.SetActive(false);
        Musik.SetActive(false);
        Pause.SetActive(true);
    }
}
