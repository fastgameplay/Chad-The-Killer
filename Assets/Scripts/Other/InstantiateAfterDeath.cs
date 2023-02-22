using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAfterDeath : MonoBehaviour{
    [SerializeField] GameObject _objectPrefab;

    void OnDestroy(){
        Instantiate(_objectPrefab,transform.position,transform.rotation);
    }
}
