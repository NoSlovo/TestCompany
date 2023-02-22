using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemPlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private DynamicJoystick _joystick;
    [SerializeField] private float _spead;

    private int _invertValue = -1;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _rb.velocity = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical) * (_spead * _invertValue);
        transform.rotation = Quaternion.LookRotation(_rb.velocity);
    }
}
