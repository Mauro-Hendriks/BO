using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summontower : MonoBehaviour
{
    public List<GameObject> TowerToSpawn = new List<GameObject>();
    mausepos Mausepos;
    public GameObject towers;

    Vector3 mause;
    // Start is called before the first frame update
    void Start()
    {
        Mausepos = FindObjectOfType<mausepos>();      
    }

    // Update is called once per frame
    void Update()
    {
        mause = Mausepos.worldPosition;
    }

    public void spawn1()
    {
        GameObject towers = (GameObject)Instantiate(TowerToSpawn[0], mause, Quaternion.identity);
    }
}
