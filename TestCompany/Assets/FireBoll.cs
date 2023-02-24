using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoll : MonoBehaviour
{
     private float _spead = 8f;
     private float _duraticon = 5f;
     private float _timeCount;

     private void FixedUpdate()
     {
          _timeCount += Time.deltaTime;
          transform.position += Vector3.left * (_spead * Time.deltaTime);
          
          if (_timeCount >= _duraticon)
                    Destroy(this.gameObject);
     }
}
