using UnityEngine;


public class EnemyGhost : MonoBehaviour
{
    [SerializeField] private int _healthPoint = 6;
    [SerializeField] private Transform _respaunPoint;
    [SerializeField] private int _respaunCounter = 1;
    [SerializeField] private int _GhostDamage = 2;


    private int _count = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(_GhostDamage);
        }
    }
    
    public void TakeDamage(int damage)
    {
        _healthPoint -= damage;
        Debug.Log($"Dmg: {damage}. HP: {_healthPoint}");
        if (_healthPoint <= 0) _respaun();
        
    }

    private void _respaun()
    {
        if (_count < _respaunCounter)
        {
            gameObject.transform.position = _respaunPoint.position;
            _healthPoint = 6;
        }
        else Destroy(gameObject);
        _count++;        
    }
}
