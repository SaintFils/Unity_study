using UnityEngine;


public class SpaunTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _startPosition;

    private int _counter = 0;


    private void OnTriggerEnter(Collider other)
    {
        if(_counter < 1)
        {
            if (other.CompareTag("Player")) _createEnemy();
            _counter++;
        }
    }

    private void _createEnemy()
    {
        Instantiate(_enemy, _startPosition.position, _startPosition.rotation);
    }
}
