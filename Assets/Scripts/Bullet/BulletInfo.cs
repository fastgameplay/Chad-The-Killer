using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInfo : MonoBehaviour
{
    public int Damage{get{return _damage;}}
    [SerializeField] int _damage;
    
    public float Speed{get{return _speed;}}
    [SerializeField] float _speed;
}
