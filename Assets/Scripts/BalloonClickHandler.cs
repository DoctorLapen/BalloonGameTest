using System;
using UnityEngine;

namespace BalloonGameTest
{
    public class BalloonClickHandler : MonoBehaviour
    {
        public event Action BalloonDestroyed;
        private ScoreCounter _scoreCounter;
        public void SubscribeCounter(ScoreCounter scoreCounter)
        {
            _scoreCounter = scoreCounter;
            BalloonDestroyed += scoreCounter.AddScore;
        }
        private void OnMouseDown()
        {
            BalloonDestroyed?.Invoke();

        }
        private void OnDisable()
        {
            BalloonDestroyed -= _scoreCounter.AddScore;
        }
    }
}
