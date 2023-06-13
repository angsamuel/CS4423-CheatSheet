using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyeBoxColor : MonoBehaviour
{
    public Color dyeColor;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Box"){
            other.GetComponent<SpriteRenderer>().color = dyeColor;
        }
    }
}
