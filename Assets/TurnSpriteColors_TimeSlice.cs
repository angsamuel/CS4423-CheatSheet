using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSpriteColors_TimeSlice : MonoBehaviour
{
    public List<SpriteRenderer> srs;
    public Color color = Color.white;

    Dictionary<Vector2Int,List<GameObject>> hashGrid;

    bool coroutineRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        if(coroutineRunning){
            return;
        }

        coroutineRunning = true;
        StartCoroutine(ChangeColorsRoutine());
    }

     IEnumerator ChangeColorsRoutine(){
        for(int i = 0; i<srs.Count; i++){
            srs[i].color = color;
            if(i%5 == 0){
                yield return null;
            }
            
        }
        yield return null;
        coroutineRunning = false;
    }
}
