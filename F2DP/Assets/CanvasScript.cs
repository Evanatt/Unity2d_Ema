using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CanvasScript : MonoBehaviour
{
    public TextMeshProUGUI contador;
    public jugarvirtualboy BOY;

    // Update is called once per frame
    void Update()
    {
        contador.text = "cerezas: " + BOY.cerezas;
    }
}
