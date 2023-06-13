using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public float speed = 3;
    Rigidbody2D rb;
    SpriteRenderer sr;
    void Awake(){
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Start(){
        
    }

    void Update(){

    }

    public void Move(Vector3 direction){
        
        rb.velocity = direction*speed;

        //flip body
        if(Mathf.Abs(rb.velocity.x) > 0){
            sr.flipX = rb.velocity.x < 0;
        }
    }

    public void RandomizeColor(){
       sr.color = Color.HSVToRGB(Random.Range(0f,1f),1,1);
    }
}
