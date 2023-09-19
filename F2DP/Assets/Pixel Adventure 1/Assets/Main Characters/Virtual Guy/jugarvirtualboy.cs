using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugarvirtualboy : MonoBehaviour
{
    public float maxspeed = 5f;
    float horizontal, vertical;
    public float speed=2600;
    public Rigidbody2D rig;
    Animator anim;
    public bool grounded = false;
    public int cerezas = 5;


    // Update is called once per frame
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(rig.velocity.x));
        anim.SetBool("grounded", grounded);
       /*horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 movimiento = ((Vector2.right * horizontal) + (Vector2.up * vertical)) * speed * Time.deltaTime;
        rig.velocity += new Vector2(movimiento.x,movimiento.y)*Time.deltaTime;
        //transform.position += new Vector3 (movimiento.x,movimiento.y,0);*/
        
    }
    void FixedUpdate()
    {
        Vector3 fixedVelocity = rig.velocity;
        fixedVelocity.x *= 0.75f;
        if (grounded)
        {
            rig.velocity = fixedVelocity;
        }
        horizontal = Input.GetAxis("Horizontal") * speed;
        rig.AddForce(Vector2.right * horizontal);
        float limitedSpeed = Mathf.Clamp(rig.velocity.x, -maxspeed, maxspeed);
        rig.velocity = new Vector2(limitedSpeed, rig.velocity.y);
        if (horizontal > 0.1f)
        {
            transform.localScale = new Vector3(3.76f, 3.76f, 3.76f);
        }
        if (horizontal < -0.1f)
        {
            transform.localScale = new Vector3(-3.76f,3.76f, 3.76f);
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Terreno")
        {
            Debug.Log("Estoy en el suelo");
        }
        if (other.gameObject.tag == "Trofeo")
        {
            Debug.Log("Gane un trofeo");
        }
    }
}
