using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrofeoScript : MonoBehaviour
{
    public Animator Anim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Anim.SetBool("Win", true);
        }

    }

}
