using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyInfo : MonoBehaviour
{
    public int HP;
    public int damage;
    public goldHandeler Gold;
    public int GGold;
    // Start is called before the first frame update
    void Start()
    {
        GGold = Gold.Gold;
        
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

    
}
