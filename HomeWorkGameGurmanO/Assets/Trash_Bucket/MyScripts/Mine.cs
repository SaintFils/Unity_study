using UnityEngine;


public class Mine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyGhost>()?.TakeDamage(2);
            Destroy(gameObject);
        }
    }
}
