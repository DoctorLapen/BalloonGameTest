
using UnityEngine;

namespace BalloonGameTest
{
    public class BalloonSpawner : MonoBehaviour
    {
        private const float SPAWN_DELAY = 1f;
        [SerializeField]
        private BalloonClickHandler[] _balloonPrefabs;
        [SerializeField]
        private ScoreCounter _scoreCounter;
        [SerializeField]
        private float _spawnSpeed;
        [SerializeField]
        private float _spawnRadius;
        [SerializeField]
        private float _increaseSpawnSpeedStep;
        [SerializeField]
        private int _balloonsTotalAmount;
        public int BalloonsTotalAmount => _balloonsTotalAmount;
        private float _t;
        private float _minBallonIndex = 0;
        private float _maxBallonIndex;
        private int _spawnedBalloons = 0;
        private void Start()
        {
            _t = SPAWN_DELAY;
            _maxBallonIndex = _balloonPrefabs.Length - 1;
        }

        private void Update()
        {

            if (_t > SPAWN_DELAY && _balloonsTotalAmount > _spawnedBalloons)
            {
                int newBalloonIndex = (int)Random.Range(_minBallonIndex, _maxBallonIndex);
                BalloonClickHandler newBalloon = _balloonPrefabs[newBalloonIndex];
                Vector3 balloonPosition = transform.position;
                balloonPosition.x += Random.Range(-_spawnRadius, _spawnRadius);
                BalloonClickHandler spawnedBalloon = Instantiate(newBalloon, balloonPosition, Quaternion.identity);
                spawnedBalloon.SubscribeCounter(_scoreCounter);
                _t = 0;
                _spawnedBalloons++;
                _spawnSpeed += _increaseSpawnSpeedStep;
            }
            _t += Time.deltaTime * _spawnSpeed;
        }
    }
}
