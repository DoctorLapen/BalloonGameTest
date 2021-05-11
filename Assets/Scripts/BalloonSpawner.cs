using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BalloonGameTest
{
    public class BalloonSpawner : MonoBehaviour
    {
        private const float SPAWN_DELAY = 1f;
        [SerializeField]
        private Balloon[] _balloonPrefabs;
        [SerializeField]
        private ScoreCounter _scoreCounter;
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
                Balloon newBalloon = _balloonPrefabs[newBalloonIndex];
                Balloon spawnedBalloon = Instantiate(newBalloon,transform.position,Quaternion.identity);
                spawnedBalloon.SubscribeCounter(_scoreCounter);
                _t = 0;
            }
            _t += Time.deltaTime * _spawnSpeed;
        }
    }
}
