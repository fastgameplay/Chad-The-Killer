using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColision : MonoBehaviour{

    void OnCollisionEnter(Collision collision){
        Debug.Log("Colision");  
        if(collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
        }
        gameObject.SetActive(false);
    }
}
