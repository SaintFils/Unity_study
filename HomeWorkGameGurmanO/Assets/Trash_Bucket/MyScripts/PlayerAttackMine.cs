using UnityEngine;


public class PlayerAttackMine : MonoBehaviour
{
    [SerializeField] private GameObject _mine = null;
    [SerializeField] private Transform _spawnPosition;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_mine, _spawnPosition.position, Quaternion.Euler(-90,0,0));
        }
    }
}
