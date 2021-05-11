using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BalloonGameTest
{
    public class BalloonSpawner : MonoBehaviour
    {
        private const float SPAWN_DELAY = 1f;
        [SerializeField]
        private GameObject[] _balloonPrefabs;
        [SerializeField]
        private float _spawnSpeed;
        private float _t;
        private float _minBallonIndex = 0;
        private float _maxBallonIndex;
        void Start()
        {
            _t = SPAWN_DELAY;
            _maxBallonIndex = _balloonPrefabs.Length - 1;
        }

        void Update()
        {

            if (_t > SPAWN_DELAY)
            {
                int newBalloonIndex = (int)Random.Range(_minBallonIndex, _maxBallonIndex);
                GameObject newBalloon = _balloonPrefabs[newBalloonIndex];
                Instantiate(newBalloon,transform.position,Quaternion.identity);
                _t = 0;
            }
            _t += Time.deltaTime * _spawnSpeed;
        }
    }
}
