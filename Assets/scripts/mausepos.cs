using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mausepos : MonoBehaviour
{
    TerrainCollider terrainCollider;
    public Vector3 worldPosition;
    Ray ray;

    void Start()
    {
        terrainCollider = Terrain.activeTerrain.GetComponent<TerrainCollider>();
    }
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;
        if (terrainCollider.Raycast(ray, out hitData,10000000))
        {
            worldPosition = hitData.point;
            
        }
        
    }
}
