using UnityEngine;


public class TurretBullets : MonoBehaviour
{
    [SerializeField] private float _fireSpeed = 7.0f;

    private const int _turretDamage = 1;
   
    void Start()
    {
        Destroy(gameObject, 4);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _fireSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(_turretDamage);
            Destroy(gameObject);
        }
    }
}
