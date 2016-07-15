using UnityEngine;
using System.Collections;

public class RandomEnemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class EnemyInfo
    {
        public GameObject enemy;
        [Range(0,1)]
        public float spawnChance;
    }

    public EnemyInfo[] enemies;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SpawnRandomEnemy();
        }
    }

    public void SpawnRandomEnemy()
    {
        float random = Random.value; // our % chance

        float totalChance = 0;
        float prevTotalChance = 0;
        foreach (var item in enemies)
        {
            totalChance += item.spawnChance;
            if (random > prevTotalChance && random < totalChance )
            {
                //spawn
                Instantiate(item.enemy, transform.position, Quaternion.identity);

                // we're done with this script - we don't want it to respawn every time the player comes back
                GetComponent<Collider2D>().enabled = false;
                break;
            }

            prevTotalChance = totalChance;
        }
    }
}


