using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CollectibleSpawner))]
public class CollectibleSpawnerInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        CollectibleSpawner cs = (CollectibleSpawner)target;

        if(GUILayout.Button("Generate"))
        {
            cs.Spawn();
        }


        if (GUILayout.Button("Destroy"))
        {
            DestroyAll();
        }
    }

    void DestroyAll()
    {
        CollectibleSpawner cs = (CollectibleSpawner)target;

        System.Collections.Generic.List<GameObject> children = new System.Collections.Generic.List<GameObject>();
        foreach (Transform item in cs.transform)
        {
            children.Add(item.gameObject);
            
        }

        foreach (var item in children)
        {
            DestroyImmediate(item);
        }
        
    }
}