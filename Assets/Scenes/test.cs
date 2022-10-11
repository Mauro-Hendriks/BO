using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public GameObject A;
    public GameObject B;
    public Vector3 dif;
    // Start is called before the first frame update
    void Start()
    {
        A = GameObject.Find("A");
        B = GameObject.Find("B");
        
        transform.position = A.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        dif = B.transform.position - transform.position;
        if (dif.magnitude > Time.deltaTime)
        {
            dif = Vector3.Normalize(dif);
            transform.position += dif * Time.deltaTime;
        }
        else
        {
            transform.position = A.transform.position;
        }
        
    }
}
