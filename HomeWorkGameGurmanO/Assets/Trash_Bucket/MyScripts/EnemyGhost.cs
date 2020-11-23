using UnityEngine;


public class EnemyGhost : MonoBehaviour
{
    [SerializeField] private int _healthPoint;

    public void TakeDamage(int damage)
    {
        _healthPoint -= damage;
        Debug.Log($"Dmg: {damage}. HP: {_healthPoint}");
        if (_healthPoint <= 0) Destroy(gameObject);
    }
}
