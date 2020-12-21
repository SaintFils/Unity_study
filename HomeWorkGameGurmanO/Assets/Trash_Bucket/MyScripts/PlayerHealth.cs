using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _healthPoint = 6;
    [SerializeField] private Transform _respaunPoint;
    [SerializeField] private int _respaunCounter = 1; //сколько раз игрок может респауниться
    [SerializeField] private Texture2D _healthPointIcon;

    private int _count = 0;

    private void OnGUI()
    {
        GUI.Box(new Rect(0, Screen.height - 50, 150, 50), new GUIContent($" {_healthPoint} Health Points", _healthPointIcon));
    }

    public void TakeDamage(int damage)
    {
        _healthPoint -= damage;
        Debug.Log($"Dmg: {damage}. HP: {_healthPoint}");
        if (_healthPoint <= 0) _respaun();
    }

    public void TakeHeal(int heal)
    {
        _healthPoint += heal;
        Debug.Log($"HP: {_healthPoint}");
    }

    private void _respaun()
    {
        if (_count < _respaunCounter)
        {
            gameObject.transform.position = _respaunPoint.position;
            _healthPoint = 6;
        }
        else
        {
            Destroy(gameObject);
        }
        _count++;
    }
}
