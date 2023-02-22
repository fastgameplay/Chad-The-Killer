using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointLink : MonoBehaviour
{
    [SerializeField] WayPoint _wayPoint;

    void Start(){
        if(_wayPoint == null){
            Debug.LogError("_WayPoint is not selected");
        }
        _wayPoint.SubscribeEnemy();
    }
    void OnDestroy(){
        _wayPoint.UnscribeEnemy();
    }
}
