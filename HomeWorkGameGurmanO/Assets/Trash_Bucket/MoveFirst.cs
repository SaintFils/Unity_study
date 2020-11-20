using UnityEngine;


public class MoveFirst : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;

    private Vector3 _direction = Vector3.zero; 


     private void Update()
    {
        _direction.x = -Input.GetAxis("Horizontal"); //у ассета форвард направлен назад, поэтому приходится минусовать значение
        _direction.z = -Input.GetAxis("Vertical");
        _direction.Normalize();
    }


    private void FixedUpdate()
    {
        transform.position += _direction * Time.deltaTime * _speed;
    }
}
