using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Collider2D))]
public class SpikeyController : MonoBehaviour
{
    Animator anim;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (anim == null)
                anim = GetComponent<Animator>();
            anim.SetBool("active", true);
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (anim == null)
                anim = GetComponent<Animator>();
            anim.SetBool("active", false);
        }
    }

    /*
    public Rigidbody2D spikeCenter;
    public Rigidbody2D spikeLeft;
    public Rigidbody2D spikeRight;
    */
    public float spikeLifeTime = 1f;
    public float spikeForce = 1f;

    /*
    private Vector2 spikeCenterDirection = Vector2.up;
    private Vector2 spikeLeftDirection = new Vector2(-1f, 1f);
    private Vector2 spikeRightDirection = new Vector2(1f, 1f);
    
    public void Shoot()
    {
        //Debug.Log("shoot");

        GameObject spikeCenterClone = 
            Instantiate(spikeCenter.gameObject, spikeCenter.transform.position, Quaternion.identity) as GameObject;
        GameObject spikeLeftClone = 
            Instantiate(spikeLeft.gameObject, spikeLeft.transform.position, Quaternion.identity) as GameObject;
        GameObject spikeRightClone = 
            Instantiate(spikeRight.gameObject, spikeRight.transform.position, Quaternion.identity) as GameObject;

        spikeCenterClone.SetActive(true);
        spikeLeftClone.SetActive(true);
        spikeRightClone.SetActive(true);

        Rigidbody2D centerRb2d = spikeCenterClone.GetComponent<Rigidbody2D>();
        Rigidbody2D leftRb2d = spikeLeftClone.GetComponent<Rigidbody2D>();
        Rigidbody2D rightRb2d = spikeRightClone.GetComponent<Rigidbody2D>();

        centerRb2d.AddForce(spikeForce * spikeCenterDirection, ForceMode2D.Impulse);
        leftRb2d.AddForce(spikeForce * spikeLeftDirection, ForceMode2D.Impulse);
        rightRb2d.AddForce(spikeForce * spikeRightDirection, ForceMode2D.Impulse);

        Destroy(spikeCenterClone, spikeLifeTime);
        Destroy(spikeLeftClone, spikeLifeTime);
        Destroy(spikeRightClone, spikeLifeTime);
    }
    */

    // Refactor for patterns!
    [System.Serializable]
    public class Spike
    {
        public Rigidbody2D rb2d;
        public Vector2 direction;
    }

    public Spike[] spikes;

    public void Shoot()
    {
        if (spikes == null)
            return;

        foreach (var item in spikes)
        {
            if (item.rb2d == null)
                continue;

            GameObject clone = 
                Instantiate(item.rb2d.gameObject) as GameObject;

            clone.SetActive(true);
            clone.transform.SetParent(item.rb2d.transform.parent);
            clone.transform.position = item.rb2d.position;
            clone.transform.localScale = item.rb2d.transform.localScale;

            Rigidbody2D cloneRbd2 = clone.GetComponent<Rigidbody2D>();
            if (cloneRbd2)
                cloneRbd2.AddForce(item.direction * spikeForce, ForceMode2D.Impulse);

            Destroy(clone, spikeLifeTime);
        }
    }
}
