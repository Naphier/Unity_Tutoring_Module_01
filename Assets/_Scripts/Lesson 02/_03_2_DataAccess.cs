using UnityEngine;
using System.Collections;

public class _03_2_DataAccess : MonoBehaviour
{
    void Start()
    {
        GameObject dataEncapGO = GameObject.Find("Data Encapsulation");
        if (dataEncapGO)
        {
            _03_DataEncapsulation dataEncap = dataEncapGO.GetComponent<_03_DataEncapsulation>();
            if (dataEncap)
                dataEncap.TagMe();
        }
            
    }

    void Update()
    {

    }

    // Explain importance.
}
