using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testraycast : MonoBehaviour
{
    // Start is called before the first frame update
    mausepos Mausepos;
    Vector3 mause;
    void Start()
    {
        Mausepos = FindObjectOfType<mausepos>();
    }

    // Update is called once per frame
    void Update()
    {
        mause = Mausepos.worldPosition;
        transform.position = mause;
    }
}
