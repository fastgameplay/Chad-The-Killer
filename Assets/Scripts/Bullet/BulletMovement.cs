using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BulletInfo))]
public class BulletMovement : MonoBehaviour
{
    float _speed;
    
    void Awake(){
        _speed = GetComponent<BulletInfo>().Speed;
    }

    void Update(){
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
