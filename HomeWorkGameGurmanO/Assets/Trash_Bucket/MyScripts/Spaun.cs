using UnityEngine;


public class Spaun : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _enemyCheck;
    [SerializeField] private Transform _startPosition;

    private void Start()
    {
        //Instantiate(_enemy, _startPosition.position, _startPosition.rotation);        
    }


    private void Update()
    {
       BBB();
    }

    private void BBB()
    {      
        if (_enemyCheck == null)
        {
           _enemyCheck = Instantiate(_enemy, _startPosition.position, _startPosition.rotation);               
        }    
    }
}
