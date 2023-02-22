using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]

public class PlayerMovement : MonoBehaviour
{
    public float CurrentSpeed{get { return _agent.velocity.magnitude;}}

    [SerializeField] WayPoint[] _wayPoints;
    
    NavMeshAgent _agent;
    int _nextPointID;
    bool _isStart;
    void Awake(){
        _agent = GetComponent<NavMeshAgent>();
        _nextPointID = 0;
        _isStart = true;
    }   
    
    void Update(){
        if(_isStart){
            if(Input.GetMouseButtonDown(0)){
                _agent.SetDestination(_wayPoints[_nextPointID].transform.position);
                _nextPointID++;
                _isStart = false;
                //activate attack;
                //deactivate tap panel;
            }
        }
        else{
            CheckPoints();
        }


        
            
    }

    void CheckPoints(){
        if(_agent.remainingDistance > 0.5f) return;
        if(_wayPoints[_nextPointID-1].IsClear == false) return;
        if(!_wayPoints[_nextPointID-1].IsFinish){

            _agent.SetDestination(_wayPoints[_nextPointID].transform.position);
            _nextPointID++;
            return;
        }
        Debug.Log("Win");
        //win logic(panel active, restart scene)
    }
}
