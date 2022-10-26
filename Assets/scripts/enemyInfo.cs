using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemyInfo : MonoBehaviour
{
    public int HP;
    public int damage;
    public goldHandeler Gold;
    public int GGold;
    public Slider health;
    // Start is called before the first frame update
    void Start()
    {
        health.maxValue = HP;
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            GGold = GGold + 1;
            Destroy(this.gameObject);
        }
        
    }
    void OnDestroy()
    {
        
        if (GameObject.FindGameObjectWithTag("WaveSpawner") != null)
        {
            GameObject.FindGameObjectWithTag("WaveSpawner").GetComponent<wave_spawner>().SpawnedEnemies.Remove(gameObject);
        }

        if (GameObject.FindGameObjectWithTag("Tower") != null)
        {
            GameObject.FindGameObjectWithTag("Tower").GetComponent<towersinfo>().enemy.Remove(gameObject);
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
