using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColision : MonoBehaviour{

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Enemy"){
            collision.gameObject.GetComponent<EnemyDeathManager>().UnAlive();
        }
        gameObject.SetActive(false);
    }
}
