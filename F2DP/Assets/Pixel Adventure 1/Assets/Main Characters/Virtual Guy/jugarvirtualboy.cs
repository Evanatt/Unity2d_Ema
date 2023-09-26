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
    public int cerezas = 0;
    public CanvasScript Canvascanvas;
    public CameraMoveScript moves;
    // Update is called once per frame
    private void Start()
    {
        moves= FindAnyObjectByType<CameraMoveScript>();
        Canvascanvas = FindAnyObjectByType<CanvasScript>();
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(rig.velocity.x));
        anim.SetBool("grounded", grounded);        
    }
    void FixedUpdate()
    {
        if (!moves.shiftPressed) // solo se mueve si no esta presionada la tecla shift
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
                transform.localScale = new Vector3(-3.76f, 3.76f, 3.76f);
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Trofeo")
        {
            Canvascanvas.Activarcanvas();
        }

    }

}
