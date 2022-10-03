using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delenemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            
            Destroy(other.gameObject);
            //Destroy(gameObject.tag("Enemy"));


        }
    }
}
