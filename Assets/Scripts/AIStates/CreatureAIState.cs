using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CreatureAIState 
{

    protected CreatureAI creatureAI;
    protected float timer = 0;
    public CreatureAIState(CreatureAI newAI){
        creatureAI = newAI;
    } 

    public void UpdateStateBase(){
        timer+=Time.deltaTime;
        UpdateState();
    }

    public void BeginStateBase(){
        timer = 0;
        BeginState();
    }


    //When we start the state up 
    protected abstract void UpdateState();
    //Tick Method 
    protected abstract void BeginState();
}

