using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameResource.Sctipts
{
    public class SpawnCoin : MonoBehaviour
    {
        [SerializeField] private Coin _prefabCoin;
        [SerializeField] private Vector3 _volome;
        [SerializeField] private GameObject _spawnCube;
        [SerializeField] private float _durationSpawn;

        private void Start()
        {
            StartCoroutine(SpawnCoint());
        }


        private IEnumerator SpawnCoint()
        {
            int maxSpawnCoin = 10;
            var waitForSecondsRealtime = new WaitForSecondsRealtime(_durationSpawn);

            while (maxSpawnCoin > 0)
            {
                maxSpawnCoin--;
                var position = new Vector3(
                    Random.Range(_spawnCube.transform.position.x - _volome.x,
                        _spawnCube.transform.position.x + _volome.x), _spawnCube.transform.position.y,
                    Random.Range(_spawnCube.transform.position.z - _volome.z,
                        _spawnCube.transform.position.z + _volome.z));
                var coin = Instantiate(_prefabCoin);
                coin.transform.position = position;
                coin.transform.rotation = Quaternion.Euler(90, 0, 0);
                yield return waitForSecondsRealtime;
            }
        }
    }
}