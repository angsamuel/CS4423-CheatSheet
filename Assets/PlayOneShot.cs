using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneShot : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    void Start(){
        GetComponent<AudioSource>().PlayOneShot(clip1);
        GetComponent<AudioSource>().PlayOneShot(clip2);
    }
}
