using UnityEngine;
using System.Collections;


public class TurretBeh : MonoBehaviour
{
    [SerializeField] GameObject _bullet;    
    [SerializeField] private float _enemyReaction = 5.0f;
    [SerializeField] private float _fireRate = 1.0f;
    private Transform _target;

   

    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(_turretSearch());
    }


    private void _fire()
    {
        Instantiate(_bullet, transform.position, transform.rotation);        
    }

    private IEnumerator _turretSearch()
    {
        while (true)
        {
            if (Vector3.Distance(transform.position, _target.position) < _enemyReaction)
            {
                transform.LookAt(_target.position);
                _fire();
            }

            yield return new WaitForSeconds(_fireRate);
        }
    }
    
}
