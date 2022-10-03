using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public LayerMask layermask;
    public int offset1 = 1;

    RaycastHit hitinfo;
    void Start()
    {
        if (Physics.Raycast(transform.position, -Vector3.up, out hitinfo, Mathf.Infinity, layermask))
        {
            Debug.DrawRay(transform.position, -Vector3.up, Color.red, 5);
            Debug.Log(hitinfo.transform);
            Debug.Log(hitinfo.distance);
        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
