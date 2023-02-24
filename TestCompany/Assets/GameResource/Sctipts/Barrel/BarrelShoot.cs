using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelShoot : MonoBehaviour
{
   [SerializeField] private FireBoll _fireBoll;
   [SerializeField] private Transform _spawnPoint;
   [SerializeField] private Quaternion _quaternionFirebol;

   private void Start()
   {
      Shoot();
   }

   private void Shoot()
   {
      var fireboll = Instantiate(_fireBoll, _spawnPoint.transform);
      fireboll.transform.position = _spawnPoint.transform.position;
      fireboll.transform.rotation = _quaternionFirebol;
   }
}
