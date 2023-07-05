using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureAIPatrolState : CreatureAIState
{
    public CreatureAIPatrolState(CreatureAI creatureAI) : base(creatureAI){}

    protected override void BeginState()
    {
        MoveRandom();
        creatureAI.myCreature.GetComponent<SpriteRenderer>().color = Color.blue;
    }
    Vector3 moveVec;
    protected override void UpdateState()
    {
        Debug.Log(timer);
        if(timer > 1.5f){
            timer = 0;
           
            MoveRandom();
        }
        
        creatureAI.myCreature.Move(moveVec);

        if(creatureAI.GetTarget() != null){
            creatureAI.ChangeState(creatureAI.hugState);
        }
    }

    public void MoveRandom(){
        moveVec = (new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f),0));
    }

}
