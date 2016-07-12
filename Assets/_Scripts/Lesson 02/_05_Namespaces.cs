using UnityEngine; // <-- Unity's main API namespace (MonoBehaviour, GameObject, Transform, etc)
using System.Collections; // <-- in Unity mostly for IEnumerator coroutines (more info: https://msdn.microsoft.com/en-us/library/system.collections)

// Can replace shorthand
using Debug = Napland.Debug;

// Other frequently used namespaces
using System.Collections.Generic; // Contains Lists and Dictionaries
using UnityEngine.UI; // UI functionalities
using UnityEngine.Events; // Delegate events


public class _05_Namespaces : MonoBehaviour
{
    void Start()
    {
        Napland.MyEncapsulatedClass mec = new Napland.MyEncapsulatedClass(); // can write out long hand

        Debug.Log(mec.ToString());
    }
}

// Unity API is anything in any of the Unity namespaces. Provides functionality to make the app work!
// --> your best friend! https://docs.unity3d.com/ScriptReference/
// .NET API (currently only "Mono" -- a flavor of .NET 2.0 -- available in Unity)
//  your other best friend --> https://msdn.microsoft.com/en-us/library/aa139623.aspx 
// .NET 2.0 reference, (maybe Google is better?)

namespace Napland
{
    public class MyEncapsulatedClass { }

    public static class Debug
    {
        public static void Log(string message)
        {
            UnityEngine.Debug.Log("[Napland] " + message);
        }
    }

}