using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]

public class PlayerAnimation : MonoBehaviour{
    Animator _animator;
    PlayerMovement _movement;

    void Awake(){
        _animator = GetComponentInChildren<Animator>();
        _movement = GetComponent<PlayerMovement>();
    }

    void Update(){
        _animator.SetFloat("Speed",_movement.CurrentSpeed);
    }
}
