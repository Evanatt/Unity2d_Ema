using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CapsulaMove : MonoBehaviour
{
    public Rigidbody capsule;
    public float speedMove;
    public float horizontal;
    public float vertical;
    public float rotSpeed;

    Vector2 playermouseinput;
    public Transform playercamera;
    float XRot, YRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(horizontal,0f,vertical).normalized;

        transform.position += direccion * speedMove * Time.deltaTime;


        playermouseinput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        //move player cam
        XRot-=playermouseinput.y*rotSpeed*Time.deltaTime;
        transform.Rotate(0f, playermouseinput.x * rotSpeed*Time.deltaTime, 0f);
        playercamera.LookAt(playermouseinput);
        playercamera.transform.localRotation = Quaternion.Euler(XRot, 0f, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Puerta")
        {
            SceneManager.LoadScene(2);
        }
        if(other.gameObject.tag == "Salir")
        {
            Application.Quit();
        }
    }
}
