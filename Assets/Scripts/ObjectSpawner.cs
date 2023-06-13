using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float pauseTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObjectsRoutine()); //remember to include StartCoroutine!
    }

    IEnumerator SpawnObjectsRoutine(){
        while(true){ //loop...forever! mwahahaha
            Vector3 randomSpawnPos = new Vector3(Random.Range(-5f,5f),Random.Range(-5f,5f),0);
            GameObject newObject = Instantiate(prefabToSpawn,randomSpawnPos,Quaternion.identity);
            Destroy(newObject,10); //destroy after 10 seconds so they don't build up
            yield return new WaitForSeconds(pauseTime);
        }
        yield return null;
    }
}
