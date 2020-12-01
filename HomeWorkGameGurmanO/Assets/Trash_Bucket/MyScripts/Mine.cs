using UnityEngine;


public class Mine : MonoBehaviour
{
    [SerializeField] private int _damage = 2;
    void Start()
    {
        Destroy(gameObject, 4);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyGhost>()?.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
