using UnityEngine;
using UnityEngine.AI;


public class MyWaypointPatrol : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _navMeshAgent;
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private Transform _player;
    [SerializeField] private LayerMask _mask;

    private RaycastHit hit;
    private bool isPatrol = true;
    private int m_CurrentWaypointIndex = 0;

    private void Awake()
    {
        _player = GameObject.FindObjectOfType<PlayerMove>().transform;
    }

    void Start()
    {
        _navMeshAgent.SetDestination(_waypoints[m_CurrentWaypointIndex].position);
        _navMeshAgent.speed = Random.Range(0.5f, 2f);
    }

    private void FixedUpdate()
    {
        Color raycastLineColor = Color.red;

        Vector3 startPosition = CalculateOffset(transform.position, 0.5f);
        Vector3 directionRaycast = CalculateOffset(_player.position, 0.5f) - startPosition;

        var raycast = Physics.Raycast(startPosition, directionRaycast, out hit, directionRaycast.magnitude, _mask);

        if (raycast)
        {
            if (hit.transform.CompareTag("Player"))
            {
                raycastLineColor = Color.green;
                FollowTarget();
            }
            else
            {
                Comeback();
            }
        }

        Debug.DrawLine(startPosition, CalculateOffset(_player.position, 0.5f), raycastLineColor);
    }

    #region Method

    public void SetWaypoint(Transform[] wayPoints)
    {
        _waypoints = wayPoints;
    }

    private Vector3 CalculateOffset(Vector3 position, float offset)
    {
        position.y += offset;
        return position;
    }

    private void Comeback()
    {
        if (isPatrol == true && _navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % _waypoints.Length;
            _navMeshAgent.SetDestination(_waypoints[m_CurrentWaypointIndex].position);
        }
        else if (!isPatrol)
        {
            Wait();
            Invoke(nameof(Go), 2f);
            _navMeshAgent.SetDestination(_waypoints[m_CurrentWaypointIndex].position);
            isPatrol = true;
        }
    }

    private void FollowTarget()
    {
        isPatrol = false;
        _navMeshAgent.SetDestination(_player.position);
    }

    private void Wait()
    {
        _navMeshAgent.isStopped = true;
    }

    private void Go()
    {
        _navMeshAgent.isStopped = false;
    }

    #endregion
}
