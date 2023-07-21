using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXHandler : MonoBehaviour
{

    public static SFXHandler singleton;

    void Awake(){
        if(singleton != null){
            Destroy(this.gameObject);
        }else{
            singleton = this;
        }
    }



    public void PlaySound(AudioClip ac){
        GetComponent<AudioSource>().PlayOneShot(ac);
    }
}
