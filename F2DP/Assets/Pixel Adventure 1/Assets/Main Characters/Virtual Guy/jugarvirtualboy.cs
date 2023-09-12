using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugarvirtualboy : MonoBehaviour
{
    float horizontal, vertical;
    public float speed=20;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 movimiento = ((Vector2.right * horizontal) * (Vector2.up * vertical)) * speed * Time.deltaTime;
        transform.position += new Vector3 (movimiento.x,movimiento.y,0);
    }
}
