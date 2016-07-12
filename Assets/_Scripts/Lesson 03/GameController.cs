using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public PlayerController player;
    public Transform startPosition;

    private Transform lastCheckpoint = null;

    public void Restart()
    {
        if (lastCheckpoint != null)
            player.transform.position = lastCheckpoint.position;
        else
            player.transform.position = startPosition.position;

        player.Reset();
    }

    public void SetLastCheckpoint(Transform checkpoint)
    {
        lastCheckpoint = checkpoint;
    }
}
