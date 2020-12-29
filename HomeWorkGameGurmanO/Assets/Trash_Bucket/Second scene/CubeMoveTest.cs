using UnityEngine;
using UnityEngine.AI;

public class CubeMoveTest : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private NavMeshAgent _navMeshAgent;

    private int m_CurrentWaypointIndex = 0;

    private void Start()
    {
        _navMeshAgent.SetDestination(_waypoints[m_CurrentWaypointIndex].position);       
    }

    private void FixedUpdate()
    {
        if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % _waypoints.Length;
            _navMeshAgent.SetDestination(_waypoints[m_CurrentWaypointIndex].position);
        }
    }
}
