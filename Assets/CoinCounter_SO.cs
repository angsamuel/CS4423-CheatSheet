using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinCounter_SO : MonoBehaviour
{
    public CreatureSO cso;
    Text coinText;
    void Awake(){
        coinText = GetComponent<Text>();
    }
    void Update(){
        coinText.text = cso.money.ToString();
    }
}
