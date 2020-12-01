using UnityEngine;


public class SpaunTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _startPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) _createEnemy();
    }

    private void _createEnemy()
    {
        Instantiate(_enemy, _startPosition.position, _startPosition.rotation);
    }
}
