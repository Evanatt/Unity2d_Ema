using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camrot : MonoBehaviour
{
    public float horizontalcam;
    public float verticalcam;
    public float rotSpeed;


    public Transform orientacion;
    float XRot, YRot;
    Vector2 playermouseinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pa rotar 
        horizontalcam = Input.GetAxisRaw("Mouse X") * rotSpeed * Time.deltaTime;
        verticalcam = Input.GetAxisRaw("Mouse Y") * rotSpeed * Time.deltaTime;

        YRot += horizontalcam;
        XRot -= verticalcam;
        XRot = Mathf.Clamp(XRot, -30, 30);
 

        transform.rotation = Quaternion.Euler(XRot, YRot, 0);
        //transform.LookAt(orientacion);
        orientacion.rotation = Quaternion.Euler(0, YRot, 0);
    }
}
