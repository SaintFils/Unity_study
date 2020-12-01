using UnityEngine;


public class EnemyGhost : MonoBehaviour
{
    [SerializeField] private int _healthPoint = 6;
    [SerializeField] private Transform _respaunPoint;
    [SerializeField] private int _respaunCounter = 1;
    private int count = 0;

    public void TakeDamage(int damage)
    {
        _healthPoint -= damage;
        Debug.Log($"Dmg: {damage}. HP: {_healthPoint}");
        if (_healthPoint <= 0) _respaun();
        
    }

    private void _respaun()
    {
        if (count < _respaunCounter)
        {
            gameObject.transform.position = _respaunPoint.position;
            _healthPoint = 6;
        }
        else Destroy(gameObject);
        count++;        
    }
}
