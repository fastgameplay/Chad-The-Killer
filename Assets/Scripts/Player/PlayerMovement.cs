using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]

public class PlayerMovement : MonoBehaviour
{
    public float CurrentSpeed{get { return _agent.velocity.magnitude;}}

    [SerializeField] Transform[] _wayPoints;
    
    NavMeshAgent _agent;
    int _wayPointCounter;
    
    void Awake(){
        _agent = GetComponent<NavMeshAgent>();
        _wayPointCounter = 0;
    }   
    
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            _agent.SetDestination(_wayPoints[_wayPointCounter].position);

            if(_wayPointCounter < _wayPoints.Length-1){
                _wayPointCounter++;
            }
        }
    }
}
