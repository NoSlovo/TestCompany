using UnityEngine;

namespace GameResource.Sctipts
{
    [RequireComponent(typeof(PlayerAnimator))]
    [RequireComponent(typeof(Rigidbody))]
    public class SystemPlayerMove : MonoBehaviour
    {
        [SerializeField] private DynamicJoystick _joystick;
        [SerializeField] private float _spead;
        [SerializeField] private PlayerAnimator _animator;

        private Rigidbody _rb;
        private int _invertValue = -1;
    
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _animator = GetComponent<PlayerAnimator>();
        }
    
        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (_joystick.Direction != Vector2.zero)
            {
                _rb.velocity = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical) * (_spead * _invertValue);
                transform.rotation = Quaternion.LookRotation(_rb.velocity);
                _animator.Move();
            }
            else
            {
                _animator.StopMove();
                _rb.velocity = new Vector3(0, 0, 0);
            }
        }
    }
}
