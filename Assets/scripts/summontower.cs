using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summontower : MonoBehaviour
{
    public List<GameObject> TowerToSpawn = new List<GameObject>();
    mausepos Mausepos;
    Vector3 mause;
    private goldHandeler GoldH;
    void Start()
    {
        Mausepos = FindObjectOfType<mausepos>();
        GoldH = FindObjectOfType<goldHandeler>();
    }

    // Update is called once per frame
    void Update()
    {
        mause = Mausepos.worldPosition;
    }

    public void spawn1()
    {
        if (GoldH.Gold - 5 >= 0)
        {
            GameObject towers = (GameObject)Instantiate(TowerToSpawn[0], mause, Quaternion.identity);
            GoldH.Gold = GoldH.Gold - 5;
        }

    }
}
