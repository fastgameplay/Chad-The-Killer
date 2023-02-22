using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathManager : MonoBehaviour
{
    [SerializeField] GameObject _ragdollPrefab;
    
    public void UnAlive(){
        Instantiate(_ragdollPrefab,transform.position,transform.rotation, transform.parent);
        Destroy(gameObject);
    }
}
