using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{

    [SerializeField] private GameObject Play;
    [SerializeField] private GameObject Musik;
    [SerializeField] private GameObject Pause;
    [SerializeField] private GameObject Left;
    [SerializeField] private GameObject Right;
    [SerializeField] private GameObject Up;
    [SerializeField] private GameObject Down;
    [SerializeField] private GameObject Restart;
    [SerializeField] private GameObject LVL;
    [SerializeField] private GameObject SmokeOFF;

    private void Start()
    {
        Pause.SetActive(false);
    }


   private void Update()
    {

    }

    public void OnClic()
    {
        Play.SetActive(true);
        Musik.SetActive(true);
        SmokeOFF.SetActive(true);
        Pause.SetActive(false);
        Left.SetActive(false);
        Right.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);
        Restart.SetActive(false);
        LVL.SetActive(false);
    }

}
