using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(PlayerAttack))]
public class PlayerMovement : MonoBehaviour
{
    public float CurrentSpeed{get { return _agent.velocity.magnitude;}}

    [SerializeField] WayPoint[] _wayPoints;
    
    NavMeshAgent _agent;
    GameManager _gManager;
    int _nextPointID;
    bool _isStart;
    void Awake(){
        GetComponent<PlayerAttack>().enabled = false;
        _gManager = FindObjectOfType<GameManager>();
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
                GetComponent<PlayerAttack>().enabled = true;
                _gManager.StartPanel = false;
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
        GetComponent<PlayerAttack>().enabled = false;
        _gManager.Win();
        this.enabled = false;
    }
}
