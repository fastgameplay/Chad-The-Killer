using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour{
    public bool IsFinish;
    public bool IsClear{private set; get;}

    int _enemyCount;
    void Awake(){
        IsClear = true;
        _enemyCount = 0;
    }
    public void SubscribeEnemy(){
        if(IsClear) IsClear = false;
        _enemyCount++;
    }
    public void UnscribeEnemy(){
        _enemyCount--;
        if(_enemyCount == 0){
            IsClear = true;
        }
    }
}
