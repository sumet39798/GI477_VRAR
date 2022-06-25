using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInterAction : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Hand")
        {
            other.gameObject.transform.SetParent(this.transform);
        }
        
    }
}
