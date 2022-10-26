using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towersinfo : MonoBehaviour
{
    public List<GameObject> enemy = new List<GameObject>();
    public GameObject area;
    private bool iselect = true;
    mausepos Mausepos;
    Vector3 mause;
    public bool perm = false;
    private bool ob = false;
    public GameObject bullet;
    public Transform firepiont;
    public float fireCountDown = 0f;
    public float fireRate = 0.5f;
    public Vector3 target;



    void Start()
    {
        area = transform.Find("area").gameObject;
        Mausepos = FindObjectOfType<mausepos>();
    }

    void Update()
    {
        visi();
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Debug.Log("mouse");
            perm = true;
        }
        move();
    }


    void OnMouseDown()
    {
        iselect = true;
    }
    void OnMouseUp()
    {
        iselect = false;
    }

    private void move()
    {
        if (perm == true && ob == false)
        {
            mause = transform.position;
            iselect = false;
        }
        else
        {
            mause = Mausepos.worldPosition;
        }
        transform.position = mause;
    }

    private void shoot()
    {
        GameObject bul = (GameObject)Instantiate(bullet, firepiont.position, Quaternion.identity);
        BulletMove bullets = bul.GetComponent<BulletMove>();
        target = enemy[0].transform.position;
        bullets.targetX = target.x;
        bullets.targety = target.y;
        bullets.targetz = target.z;
    }

    private void visi()
    {

        if (iselect == true)
        {
            area.SetActive(true);
        }
        if (iselect == false)
        {
            area.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("cant place");
        ob = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("can place");
        ob = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            enemy.Add(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "enemy")
        {
            if (fireCountDown <= 0f)
            {
                shoot();
                Debug.Log("shoot");
                fireCountDown = 1f / fireRate;
            }
        }
        fireCountDown -= Time.deltaTime;
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
