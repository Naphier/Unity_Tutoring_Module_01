using UnityEngine;
using System.Collections;

public class _03_DataEncapsulation : MonoBehaviour
{
    public GameObject otherGameObject;
    private GameObject privateGameObject;
    

    void Start()
    {
        if (otherGameObject)
            otherGameObject.name = "Other game object";

        privateGameObject = GameObject.Find("Look for me");
        if (privateGameObject)
            privateGameObject.name = "Found you";

        // gameObject that this script is attached to
        gameObject.name = "ME!";
    }

    public void TagMe()
    {
        gameObject.tag = "Player";
    }
}
