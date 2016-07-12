using UnityEngine; // <--
using System.Collections; // <--

public class Coroutines : MonoBehaviour
{

    void Start() // Special method for MonoBehaviour derived classes. A Unity "event"
    {
        StartCoroutine(MyCoroutine());
    }


    // Coroutines
    IEnumerator MyCoroutine()
    {
        Debug.Log("MyCoroutine starts");

        yield return new WaitForSeconds(3f);
        Debug.Log("Continued after 3 seconds");

        int index = 0;

        while (index < 100)
        {
            index++;
            yield return new WaitForEndOfFrame();
        } // waits 100 frames

        Debug.Log("Done with the while loop");

        if (index == 100)
        {
            yield break; // nothing below will execute
        }

        Debug.Log("All done");
    }
}
