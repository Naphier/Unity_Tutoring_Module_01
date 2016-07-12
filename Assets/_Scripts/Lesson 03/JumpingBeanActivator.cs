using UnityEngine;
using System.Collections;

public class JumpingBeanActivator : MonoBehaviour
{
       
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Animator anim = GetComponent<Animator>();
            if (anim)
                anim.enabled = true;

            BoxCollider2D bc2d = GetComponent<BoxCollider2D>();
            if (bc2d)
                bc2d.enabled = false;
        }
    }
}
