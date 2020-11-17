using UnityEngine;

public class Spaun : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _startPosition;

    private void Start()
    {
        Instantiate(_enemy, _startPosition.position, _startPosition.rotation);
    }

    
}
