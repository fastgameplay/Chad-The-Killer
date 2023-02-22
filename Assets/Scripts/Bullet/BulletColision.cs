using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BulletInfo))]
public class BulletColision : MonoBehaviour{
    
    int _damage;

    void Awake(){
        _damage = GetComponent<BulletInfo>().Damage;
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Enemy"){
            collision.gameObject.GetComponent<HealthManager>().Health -= _damage;
        }
        gameObject.SetActive(false);
    }
}
