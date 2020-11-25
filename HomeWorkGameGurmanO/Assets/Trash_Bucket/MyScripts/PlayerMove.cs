using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private float _turnSpeed = 3.0f;
    private float _rotation;
    private Vector3 _direction = Vector3.zero; 


     private void Update()
    {
        _rotation = Input.GetAxis("Horizontal"); 
        _direction.z = Input.GetAxis("Vertical");
        //_direction.Normalize();
    }


    private void FixedUpdate()
    {
        var playerSpeed = _direction * Time.fixedDeltaTime * _speed;
        transform.Translate(playerSpeed);
        transform.Rotate(Vector3.up * _rotation * _turnSpeed * Time.fixedDeltaTime);
    }
}
