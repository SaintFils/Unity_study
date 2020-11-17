using UnityEngine;

public class MoveFirst : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    private Vector3 _direction = Vector3.zero; 

     private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        transform.position += _direction * Time.deltaTime * -1;
        
    }
}
