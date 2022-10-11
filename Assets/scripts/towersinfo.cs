using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towersinfo : MonoBehaviour
{
    public List<GameObject> enemy = new List<GameObject>();

    void Start()
    {
        
    }

    void Update()
    {
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            enemy.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "enemy")
        {
            enemy.Remove(other.gameObject);
        }
    }

    /*private bool shoot = false;
    private float dy;
    private float dx;
    private LineRenderer lr;
    public GameObject bullet;
    private GameObject cloneBullet;

    private void OnMouseDown()
    {
        shoot = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        lr = GetComponent<LineRenderer>();
        lr.startWidth = 0.05f;

    }

    // Update is called once per frame
    void Update()
    {
        if (!shoot)
        {
            dy = transform.position.y - enemy[0].transform.position.y;
            dx = transform.position.x - enemy[0].transform.position.x;
            transform.localEulerAngles = new Vector3(0, 0, Mathf.Atan2(dy, dx) * Mathf.Rad2Deg + 100);
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, enemy[0].transform.position);
        }
        else
        {
            shoot = false;
            cloneBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            BulletMove cBullet = cloneBullet.GetComponent<BulletMove>();
            cBullet.dx = 2;
            cBullet.dy = 2;
            cBullet.speed = 2;
        }
        
    }*/
}
