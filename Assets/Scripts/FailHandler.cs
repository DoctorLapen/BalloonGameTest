using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BalloonGameTest
{
    public class FailHandler : MonoBehaviour
    {
        [SerializeField]
        private string _balloonTag;
        [SerializeField]
        private ScoreCounter _scoreCounter;
        [SerializeField]
        private BalloonSpawner _balloonSpawner;
        [SerializeField]
        private RectTransform _failPanel;

        private int _deletedBalloons = 0;

        private void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.CompareTag(_balloonTag)) 
            {
                _deletedBalloons++;
                if (_deletedBalloons + _scoreCounter.Score == _balloonSpawner.BalloonsTotalAmount) 
                {
                    _failPanel.gameObject.SetActive(true);
                    Time.timeScale = 0f;
                }
            }
        }
    }
}
