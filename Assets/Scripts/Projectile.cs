using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float damage = 0;
    
    public void Launch(Quaternion rotation, float speed, float newDamage){
        damage = newDamage;
        transform.rotation = rotation;
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
        //Destroy(this.gameObject,10);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Wall"){
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            //Destroy(this.gameObject,3f);
        }
    }
}
