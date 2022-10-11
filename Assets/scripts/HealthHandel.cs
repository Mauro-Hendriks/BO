using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthHandel : MonoBehaviour
{
    
    public TMP_Text wave;
    public int health;
    private enemyInfo incdamage;
    public int currentdamage = 0;
    private string Healthdis;
    // Start is called before the first frame update
    void Start()
    {
        
        health = 100;

        Healthdis = "Health: " + health;

        wave.text = Healthdis;
    }

    // Update is called once per frame
    void Update()
    {
        damage();
        wave.text = Healthdis;

        if (health <= 0)
        {
            SceneManager.LoadScene(2);
            Debug.Log("lost");
        }
    }

    void damage()
    {
        if (incdamage)
        {
            currentdamage = incdamage.damage;
            incdamage.damage = 0;
            health = health - currentdamage;
            Healthdis = "Health: " + health;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
           incdamage = other.GetComponent<enemyInfo>();
        }
    }
}

