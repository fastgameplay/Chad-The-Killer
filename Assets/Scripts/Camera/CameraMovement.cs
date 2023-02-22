using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target{get{return _target;} set{_target = value;} }
    [SerializeField] Transform _target;
    [SerializeField] Vector3 _offSet;
    [SerializeField] float _smoothSpeed = 0.125f;
    

    Vector3 _velosity = Vector3.zero;

    Vector3 targetPosition{get{return _target.position + _offSet;}}

    void LateUpdate(){
        if(_target != null) 
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velosity, _smoothSpeed * Time.deltaTime);
    }
}
