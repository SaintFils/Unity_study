using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] private int _healAmount = 4;

    private void Update()
    {
        transform.RotateAround(transform.position, transform.eulerAngles, 2f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>()?.TakeHeal(_healAmount);            
            Destroy(gameObject);
        }
    }
}
