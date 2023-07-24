using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscreteBar : MonoBehaviour
{
    public GameObject containerPrefab;

    public Color filledColor = Color.red;
    public Color emptyColor = Color.grey;

    public List<Image> existingContainers;

    public int defaultMax = 5;

    void Start(){
        
        SetMax(defaultMax);
        SetValue(defaultMax);
        
    }

    public void SetMax(int maxNumber){
        for(int i = 0; i<existingContainers.Count; i++){
            Destroy(existingContainers[i]);
        }
        existingContainers = new List<Image>();
        for(int i = 0; i<maxNumber; i++){
            existingContainers.Add(Instantiate(containerPrefab,this.transform).GetComponent<Image>());
        }
    }

    public void SetValue(int value){
        for(int i = 0; i<value; i++){
            existingContainers[i].color = filledColor;
        }
        for(int i = value; i<existingContainers.Count; i++){
            existingContainers[i].color = emptyColor;
        }
    }

    


}
