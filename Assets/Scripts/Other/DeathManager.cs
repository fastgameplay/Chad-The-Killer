using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] GameObject _createAfter;
    
    public void UnAlive(){
        if(_createAfter != null){
            Instantiate(_createAfter,transform.position,transform.rotation, transform.parent);
        }
        Destroy(gameObject);
    }
}
