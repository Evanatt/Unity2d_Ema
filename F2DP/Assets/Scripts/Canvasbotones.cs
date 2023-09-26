using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvasbotones : MonoBehaviour
{
    // Start is called before the first frame update
    public void Comenzar()
    {
        SceneManager.LoadScene(1);
    }
    public void salir()
    {
        Application.Quit();
    }
    public void volveralmenuprincipal()
    {
        SceneManager.LoadScene(2);

    }
    public void volveralalmundo()
    {
        SceneManager.LoadScene(0);

    }
}
