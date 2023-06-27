using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateChanger : MonoBehaviour
{
    Animator animator;
    string currentState = "Idle";
    void Awake(){
        animator = GetComponent<Animator>();

        //ChangeAnimationState("Walk");
        //ChangeAnimationState("Walk",2);
    }

    public void ChangeAnimationState(string stateName, float speed = 1){
        animator.speed = speed; //changes speed of animation

        if(stateName == currentState){
            return;
        }

        animator.Play(stateName);
        currentState = stateName;
    }
}
