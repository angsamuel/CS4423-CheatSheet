using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter_Event : MonoBehaviour
{
    Text coinText;
    int counter = 0;
    void Awake(){
        coinText = GetComponent<Text>();
    }
    public void IncreaseCoins(){
        counter += 1;
        coinText.text = counter.ToString();
    }
}
