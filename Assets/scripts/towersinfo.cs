using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towersinfo : MonoBehaviour
{
    Collider[] enemys; 
    public GameObject area;
    private bool iselect = true;
    mausepos Mausepos;
    Vector3 mause;
    public bool perm = false;
    private bool ob = false;
    public GameObject bullet;
    public Transform firepiont;
    private float fireCountDown = 0f;
    private float fireRate = 2;
    public Vector3 target;
    private Vector3 center;
    public float radius = 20;
    public LayerMask layer;

   
    void Start()
    {
        area = transform.Find("area").gameObject;
        Mausepos = FindObjectOfType<mausepos>();
        
    }

    void Update()
    {
        center = this.transform.position;
        layer = LayerMask.GetMask("enemy1");
        visi();
        if (Input.GetKey(KeyCode.Mouse1))
        {
            perm = true;
        }
        move();
        Enemy_in_range(center,radius, layer);
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


    void Enemy_in_range(Vector3 center, float radius, int layerMask)
    {
        Debug.Log("trytoshoot");

        enemys = Physics.OverlapSphere(center, radius,layerMask);
        


        if (enemys[0].tag == "enemy")
        {
            Debug.Log("found enemy");
            if (fireCountDown <= 0f)
            {
                
                shoot();
                Debug.Log("shoot");
                fireCountDown = 1f / fireRate;
            }
        }
        fireCountDown -= Time.deltaTime;
    }
    private void shoot()
    {
        Debug.Log(enemys[0].transform.position);
        GameObject bul = (GameObject)Instantiate(bullet, firepiont.position, bullet.transform.rotation);
        BulletMove bullets = bul.GetComponent<BulletMove>();
        target = enemys[0].transform.position;
        bullets.targetX = target.x;
        bullets.targety = target.y;
        bullets.targetz = target.z;
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
