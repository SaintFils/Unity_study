using UnityEngine;
using UnityEngine.AI;

public class EnemyTriggerToPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private LayerMask _mask;
    [SerializeField] private NavMeshAgent _navMeshAgent;

    private RaycastHit hit;

    private void Awake()
    {
        _player = GameObject.FindObjectOfType<PlayerMove>().transform;
    }

    private void FixedUpdate()
    {
        Color raycastLineColor = Color.red;

        Vector3 startPosition = CalculateOffset(transform.position, 0.7f);
        Vector3 directionRaycast = CalculateOffset(_player.position, 0.7f) - startPosition;

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
                _navMeshAgent.isStopped = true;
            }
        }

        Debug.DrawLine(startPosition, CalculateOffset(_player.position, 0.5f), raycastLineColor);
    }

    private Vector3 CalculateOffset(Vector3 position, float offsetY, float offsetZ = 0f)
    {
        position.y += offsetY;
        position.z += offsetZ;
        return position;
    }

    private void FollowTarget()
    {
        if (_navMeshAgent.isStopped) _navMeshAgent.isStopped = false;
       _navMeshAgent.SetDestination(_player.position);
    }
}
