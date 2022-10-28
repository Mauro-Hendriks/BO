using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemyInfo : MonoBehaviour
{
    public int HP;
    public int damage;
    public Slider health;
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        health.maxValue = HP;
        test = GameObject.Find("Gold");
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            Destroy(this.gameObject);
            goldHandeler GoldH = test.GetComponent<goldHandeler>();
            GoldH.Gold = GoldH.Gold + 2;
        }
        
    }
    void OnDestroy()
    {
        
        if (GameObject.FindGameObjectWithTag("WaveSpawner") != null)
        {
            GameObject.FindGameObjectWithTag("WaveSpawner").GetComponent<wave_spawner>().SpawnedEnemies.Remove(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);
            HP = HP - 2;
            health.value = HP;
        }
    }


}
