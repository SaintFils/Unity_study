using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _target;
    //[SerializeField] private float _cameraSpeed = 3.0f;


    private void Update()
    {
       //transform.position = Vector3.MoveTowards(transform.position, _target.position, _target.position.magnitude);
        transform.LookAt(_target);        
    }
}
