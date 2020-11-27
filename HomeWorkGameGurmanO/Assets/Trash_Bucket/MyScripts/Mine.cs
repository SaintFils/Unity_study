using UnityEngine;


public class Mine : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 4);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyGhost>()?.TakeDamage(2);
            Destroy(gameObject);
        }
    }
}
