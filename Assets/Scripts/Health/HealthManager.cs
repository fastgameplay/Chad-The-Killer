using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(DeathManager))]
public class HealthManager : MonoBehaviour
{
    public int Health {
        get{return _health;} 
        set {
            if(value <= 0){
                _healthBar.Percent = _health = value = 0;
                GetComponent<DeathManager>().UnAlive();
            }
            else{
                _health = value;
                _healthBar.Percent = _health / (float)_startHealth;
            } 

        }
    }

    [SerializeField] HealthBar _healthBar;

    [SerializeField] int _startHealth;
    int _health;

    void Awake(){
        _health = _startHealth;
    }


}
