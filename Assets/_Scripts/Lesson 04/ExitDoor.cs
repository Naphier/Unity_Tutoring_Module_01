using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public string nextLevelName = "";
    public ParticleSystem psys;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !string.IsNullOrEmpty(nextLevelName))
        {
            //SceneManager.LoadScene(nextLevelName);
            if (psys)
            {
                psys.Play();
               // Debug.Log("Play particles");
            }
            else
                Debug.LogError("Particles not found");
            
            PlayerController pc = other.GetComponent<PlayerController>();
            if (pc)
            {
                pc.Stop(true);
                pc.OnFadeOutComplete = () => { SceneManager.LoadScene(nextLevelName); };
                StartCoroutine(pc.FadeOut());
            }
            
        }
    }
}
