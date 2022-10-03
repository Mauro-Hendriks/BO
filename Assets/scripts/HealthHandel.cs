using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HealthHandel : MonoBehaviour
{
    
    public TMP_Text wave;
    public int health;
    private enemyInfo incdamage = null;
    public int currentdamage = 0;
    private string Healthdis;
    // Start is called before the first frame update
    void Start()
    {
        
        health = 100;

        Healthdis = "Health: " + health;

        wave.text = Healthdis;

        incdamage.damage = 0;
    }

    // Update is called once per frame
    void Update()
    {
      
        currentdamage = incdamage.damage;
        Debug.Log(currentdamage);
        health = health - currentdamage;
        Debug.Log(health);
        Healthdis = "Health: " + health;
      
        wave.text = Healthdis;

        if (health >= 0)
        {
            Debug.Log("lost");
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

