﻿using UnityEngine;

namespace GameResource.Sctipts.Camera
{
    public class CameraFollow: MonoBehaviour
    {
        [SerializeField] private Vector3 _offset;
        [SerializeField] private Transform _target;
        private float _magnitude = 6f;

        private void Update()
        {
            if (_target == null)
                return;
            transform.position = Vector3.Lerp(transform.position, _target.transform.position + _offset, Time.deltaTime * _magnitude);
        }
    
        public void SetTarget(Transform target) =>_target = target;
    }
}