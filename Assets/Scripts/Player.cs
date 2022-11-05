using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 MoveDirection;

    private void Start()
    {

    }

    public void OnClic()
    {
            GetComponent<Rigidbody>().velocity += MoveDirection;  
    }

    public void OnCic()
    {
        GetComponent<Rigidbody>().velocity -= MoveDirection;
    }

}
