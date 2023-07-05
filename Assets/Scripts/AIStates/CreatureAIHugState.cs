using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureAIHugState : CreatureAIState
{
    
    public CreatureAIHugState(CreatureAI creatureAI) : base(creatureAI){}


    protected override void BeginState()
    {
        creatureAI.myCreature.GetComponent<SpriteRenderer>().color = Color.red;
    }

    protected override void UpdateState()
    {
        if(creatureAI.GetTarget() != null){
            creatureAI.myCreature.MoveToward(creatureAI.GetTarget().transform.position);
        }else{
            creatureAI.ChangeState(creatureAI.patrolState);
        }
        
    }
}
