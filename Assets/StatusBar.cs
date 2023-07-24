using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBar : MonoBehaviour
{

    [Range(0,1)]
    public float testRatio = .5f;

    public Transform bar;
    public void SetStatus(float ratio){
        ratio = Mathf.Clamp(ratio,0,1);
        bar.transform.localScale = new Vector3(ratio,1,1);
    }

    void Update(){
        SetStatus(testRatio);
    }
}
