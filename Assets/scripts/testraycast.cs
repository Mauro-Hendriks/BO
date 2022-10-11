using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testraycast : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitData;
        Physics.Raycast(ray, out hitData);
        transform.position = hitData.point;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
