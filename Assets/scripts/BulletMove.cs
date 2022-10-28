using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    
    public float speed = 0.5f;
    public float targetX;
    public float targety;
    public float targetz;
    public float timeRemaining = 3;
    public Vector3 all;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = new Vector3(targetX,targety,targetz);
        transform.position = velocity;
        Debug.Log(velocity);
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
