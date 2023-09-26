using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class CanvasScript : MonoBehaviour
{
    public TextMeshProUGUI contador;
    public jugarvirtualboy BOY;
    public GameObject Complete;
    private void Start()
    {
        Complete.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        contador.text = BOY.cerezas + "/5";

    }
    public void Activarcanvas()
    {
        Complete.SetActive(true);
    }
    public void Volveralinicio()
    {
        Complete.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
