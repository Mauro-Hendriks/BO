using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave_spawner : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    public int currentWave;
    public int waveValue;
    public List<GameObject> EnemiesToSpawn = new List<GameObject>();
    public Transform[] SpawnLoca;
    public int SpawnIndex;
    public float waveDur;
    private float WaveTime;
    private float SpawnInter;
    private float SpawnTime;
    public List<GameObject> SpawnedEnemies = new List<GameObject>();
    public bool next = false;

    void Start()
    {
        GenWave();
    }

    
    void FixedUpdate()
    {
        if (next == true)
        {
            if (SpawnTime <= 0)
            {
                if (EnemiesToSpawn.Count > 0)
                {
                    GameObject enemy = (GameObject)Instantiate(EnemiesToSpawn[0], SpawnLoca[SpawnIndex].position, Quaternion.identity);
                    EnemiesToSpawn.RemoveAt(0);
                    SpawnedEnemies.Add(enemy);
                    SpawnTime = SpawnInter;

                    if (SpawnIndex + 1 <= SpawnLoca.Length - 1)
                    {
                        SpawnIndex++;
                    }
                    else
                    {
                        SpawnIndex = 0;
                    }
                }
                else
                {
                    WaveTime = 0;

                }

            }
            else
            {
                SpawnTime -= Time.fixedDeltaTime;
                WaveTime -= Time.fixedDeltaTime;
            }
            if (WaveTime <= 0 && SpawnedEnemies.Count <= 0)
            {
                currentWave++;
                GenWave();
            }
        }
    }

    public void Change()
    {
        next = true;
    }

    public void GenWave()
    {
        waveValue = currentWave * 10;
        GenEnemy();

        SpawnInter = waveDur;
        WaveTime = waveDur;
    }

    public void GenEnemy()
    {
        List<GameObject> genedEnemies = new List<GameObject>();
        while (waveValue > 0 || genedEnemies.Count < 50)
        {
            int randEnemy = Random.Range(0, enemies.Count);
            int randCost = enemies[randEnemy].cost;

            if (waveValue-randCost >= 0)
            {
                genedEnemies.Add(enemies[randEnemy].EnemyPrefab);
                waveValue -= randCost;
            }
            else if (waveValue <= 0)
            {
                break;
            }
        }
        EnemiesToSpawn.Clear();
        EnemiesToSpawn = genedEnemies;
    }

    [System.Serializable]
    public class Enemy
    {
        public GameObject EnemyPrefab;
        public int cost;
    }
}
