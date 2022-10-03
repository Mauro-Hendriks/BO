using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepoints : MonoBehaviour
{
    public Transform[] points;

    [SerializeField]
    private float sped;

    private int current;
    void Start()
    {
      
    }
    void Update()
    {
            if (transform.position != points[current].position)
            {
                transform.position = Vector3.MoveTowards(transform.position, points[current].transform.position, sped * Time.deltaTime);

            }
            else current = (current + 1) % points.Length;
    }
}
