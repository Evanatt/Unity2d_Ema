using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    [SerializeField]
    public GameObject Character;
    public Transform player;  // Referencia al objeto del jugador que seguirá la cámara
    public float sensitivity = 2.0f;
    [SerializeField]
    public float zoomSpeed = 5.0f;  // Velocidad de zoom
    public float minSize = 1.0f;    // Tamaño mínimo de la cámara
    public float maxSize = 10.0f;

    float horizontal;
    public bool shiftPressed = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shiftPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            shiftPressed = false;
        }
        if (shiftPressed)
        {
            horizontal = Mathf.Clamp(horizontal + Input.GetAxis("Horizontal") * 8f * Time.deltaTime, -8f, 50f);
            transform.position = new Vector3(horizontal, 1.781601f, -2f);
        }
        else
        {
            horizontal = player.position.x; // para resetear la posicion de la camara cuando se deja de precionar shift
            transform.position = new Vector3(player.position.x, 1.781601f, -2f);
        }

        float scrollValue = Input.GetAxis("Mouse ScrollWheel");
        float newSize = Camera.main.orthographicSize - scrollValue * zoomSpeed;
        newSize = Mathf.Clamp(newSize, minSize, maxSize);
        Camera.main.orthographicSize = newSize;

    }

}
