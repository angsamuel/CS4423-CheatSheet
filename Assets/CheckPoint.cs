using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    public string checkpoint_id = "";
    string profile;
    void Start(){
        profile = PlayerPrefs.GetString(SaveFlags.profile);

        if(PlayerPrefs.GetString(profile + SaveFlags.spawnPoint) == checkpoint_id){
            GameObject.FindGameObjectWithTag("Player").transform.position = this.transform.position;
        }

        PlayerPrefs.SetString("saved scene",SceneManager.GetActiveScene().name);

        SceneManager.LoadScene(PlayerPrefs.GetString("saved scene"));
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            PlayerPrefs.SetString(profile + SaveFlags.spawnPoint, checkpoint_id);
        }
    }


}
