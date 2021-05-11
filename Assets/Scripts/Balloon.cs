using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace BalloonGameTest
{
    public class Balloon : MonoBehaviour
    {
        public event Action BalloonDestroyed;

        [SerializeField]
        private Rigidbody2D _rb;
        [SerializeField]
        private float _minXForce;
        [SerializeField]
        private float _maxXForce;
        [SerializeField]
        private float _minYForce;
        [SerializeField]
        private float _maxYForce;
        
        private ScoreCounter _scoreCounter;

        private void Start()
        {

            Vector2 force = new Vector2(Random.Range(_minXForce, _maxXForce), Random.Range(_minYForce, _maxYForce));
            _rb.AddForce(force);
        }

        private void OnMouseDown()
        {
            BalloonDestroyed?.Invoke();
            Destroy(gameObject);
        }
        public void SubscribeCounter(ScoreCounter scoreCounter)
        {
            _scoreCounter = scoreCounter;
            BalloonDestroyed += scoreCounter.AddScore;
        }
        public void OnDisable()
        {
            BalloonDestroyed -= _scoreCounter.AddScore;
        }
    }
}
