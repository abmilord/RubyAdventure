using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coinValue = 1;

    void OnTriggerEnter2D(Collider2D other)
    
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManger.instance.ChangeScore(coinValue);
        }
    }

}
