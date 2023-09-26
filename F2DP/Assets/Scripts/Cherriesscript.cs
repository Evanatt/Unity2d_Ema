using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherriesscript : MonoBehaviour
{
    public Animator Anim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<jugarvirtualboy>().cerezas +=1;
            Anim.SetBool("Collect",true);
            Destroy(gameObject,0.3f);
        }
        // Destroy(gameObject);
    }
}
