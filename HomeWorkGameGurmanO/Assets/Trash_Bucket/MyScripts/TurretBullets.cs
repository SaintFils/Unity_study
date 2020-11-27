using UnityEngine;


public class TurretBullets : MonoBehaviour
{
    [SerializeField] private float _fireSpeed = 7.0f;
   
    void Start()
    {
        Destroy(gameObject, 4);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _fireSpeed * Time.deltaTime);
    }
}
