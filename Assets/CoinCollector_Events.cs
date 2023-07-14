using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinCollector_Events : MonoBehaviour
{
    public UnityEvent pickupCoinEvent;
    public int coins = 0;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Coin"){
            Destroy(other.gameObject);
            coins += 1;
            pickupCoinEvent.Invoke();
        }
    }


}
