using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector_SO : MonoBehaviour
{


    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;

    public CreatureSO creatureSO;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Coin"){
            creatureSO.money += 1;
            other.GetComponent<MakeSound>().PlaySound();
            Destroy(other.gameObject);
        }
    }
}
