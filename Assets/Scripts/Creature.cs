using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public float speed = 3;
    Rigidbody2D rb;
    SpriteRenderer sr;
    AnimationStateChanger animationStateChanger;

    ParticleSystem ps;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animationStateChanger = GetComponent<AnimationStateChanger>();
    }

    void Start(){

    }

    void Update(){

    }

    public void Move(Vector3 direction){
        
        rb.velocity = direction*speed;

        if(direction == Vector3.zero){
            animationStateChanger.ChangeAnimationState("Idle");
        }else{
            animationStateChanger.ChangeAnimationState("Walk",1);
        }
        

        



        //flip body
        if(Mathf.Abs(rb.velocity.x) > 0){
            sr.flipX = rb.velocity.x < 0;
        }
    }

    public void Stop(){
        Move(Vector3.zero);
    }

    public void MoveToward(Vector3 pos){
        Move((pos - transform.position).normalized);
    }

    public void RandomizeColor(){
       sr.color = Color.HSVToRGB(Random.Range(0f,1f),1,1);
    }

    void Jump(){
        animationStateChanger.ChangeAnimationState("Jump"); //
    }


}
