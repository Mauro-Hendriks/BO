using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class goldHandeler : MonoBehaviour
{
    public TMP_Text GoldDis;
    public int Gold;
    private string GoldNow;
    public int CureentGold;


    void Start()
    {
        Gold = 10;
    }

    void Update()
    {
        
        GoldNow = "Gold: " + Gold;
        GoldDis.text = GoldNow;
    }
}
