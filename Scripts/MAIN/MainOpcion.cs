using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainOpcion : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("main");
    }

    public void Salir()
    {
        Application.Quit(); 
    }

}
