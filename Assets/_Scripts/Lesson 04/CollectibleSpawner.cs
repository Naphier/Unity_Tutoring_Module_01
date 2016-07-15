using UnityEngine;
using System.Collections;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject toSpawn;
    [Range(1,1000)]
    public int number = 1;

    public float spacing = 0;

    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        Vector2 startPosition = transform.position;

        SpriteRenderer sr = toSpawn.GetComponent<SpriteRenderer>();
        if (!sr)
        {
            Debug.LogError("We need a sprite renderer to determine width");
            return;
        }

        float width = sr.bounds.size.x;


        for (int i = 0; i < number; i++)
        {
            GameObject clone = Instantiate(toSpawn);
            clone.transform.SetParent(transform);
            Vector2 position = startPosition;
            position.x = position.x + i * (width + spacing);
            clone.transform.position = position;
        }

    }
}
