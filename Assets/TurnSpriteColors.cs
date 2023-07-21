using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSpriteColors : MonoBehaviour
{
    public List<SpriteRenderer> srs;
    public Color color = Color.black;


    void Update(){
        ChangeColors();
    }

    void ChangeColors(){
        foreach(SpriteRenderer sr in srs){
            sr.color = color;
        }
    }
}
