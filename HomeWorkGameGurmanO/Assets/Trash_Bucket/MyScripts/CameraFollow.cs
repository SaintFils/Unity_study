using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 _offset = Vector3.zero;
    [SerializeField] private Transform _target;


    private void Update()
    {
        transform.position = _target.position;
        transform.position += _offset;
    }
}
