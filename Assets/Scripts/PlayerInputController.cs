using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{   
    public Creature playerCreature;

    Vector3 moveDir = Vector3.zero;
    void FixedUpdate(){
        HandleMovement();
        
    }

    void Update(){
        /* Putting this in update because we use GetKeyDown()
        GetKeyDown() returns true the first frame then false until button released
        Putting this in FixedUpdate() will cause the button press to not register 99% of the time */ 
        HandleColorChange(); 
    }

    void HandleColorChange(){
        if(Input.GetKeyDown(KeyCode.Q)){
            playerCreature.RandomizeColor();
        }
    }

    void HandleMovement(){
        moveDir = Vector3.zero;

        //GetKey() returns true if the button is pressed or held
        if(Input.GetKey(KeyCode.W)){
            moveDir.y += 1;
        }
        if(Input.GetKey(KeyCode.S)){
            moveDir.y -= 1;
        }
        if(Input.GetKey(KeyCode.A)){
            moveDir.x -= 1;
        }
        if(Input.GetKey(KeyCode.D)){
            moveDir.x += 1;
        }
        playerCreature.Move(moveDir);
    }
}
