using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
    public GameObject Area;
    public bool iselect = false;
    // Start is called before the first frame update
    void Start()
    {
        Area = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        if (iselect == true)
        {
            Debug.Log("true");
            Area.SetActive(true);
        }
        if (iselect == false)
        {
            Debug.Log("false");
            Area.SetActive(false);
        }
    }
}
