using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLS : MonoBehaviour
{
    [SerializeField] private string NumberScene;

    public void OnClicer()
    {
        SceneManager.LoadScene(NumberScene);
    }

    public void OnClic()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }





    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(NumberScene);
    }

}
