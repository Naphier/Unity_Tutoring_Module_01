using UnityEngine;
using System.Collections;

// If you want to attach to game object or run "EVENTS" during the program
// You must derive your class from MonoBehaviour.
// Also note that your file name must be the same as the class name!
// And.. class names can't start with a number (neither can variable or method names...
public class _02_MonoBehaviour : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    // This runs at the start of the scene being loaded.
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Is a little slow, don't do in Update!

        // Find - even slower
        GameObject lookForMe = GameObject.Find("Look for me");
        if (lookForMe)
            lookForMe.SetActive(false);

    }

    // This runs every frame!
    void Update()
    {
        SetSpriteColorRandomly();
    }


    void SetSpriteColorRandomly()
    {
        if (spriteRenderer)
        {
            var random = Random.Range(0.5f, 1.0f);
            Color newColor = new Color(random, 0.5f, 0.5f);
            spriteRenderer.color = newColor;
        }
    }




}
