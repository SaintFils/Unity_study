using UnityEngine;


public class DoorButton : MonoBehaviour
{
    [SerializeField] private GameObject _door = null;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _door.transform.localEulerAngles = new Vector3(0, 270, 0);
        }
    }
}
