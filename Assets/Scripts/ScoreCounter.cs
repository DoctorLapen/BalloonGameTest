using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BalloonGameTest
{
    public class ScoreCounter : MonoBehaviour
    {
        public event Action<int> ScoreUpdated;
        [SerializeField]
        private ScoreView _scoreView;
        [SerializeField]
        private int _scoreStep;
        public int Score 
        {
            get 
            { 
                return _score; 
            }
            private set 
            {
                _score = value;
                ScoreUpdated?.Invoke(_score);  
            }
        }

        private int _score;
        
        private void Start()
        {
            ScoreUpdated += _scoreView.UpdateText;
        }

       
        public void AddScore()
        {
            Score += _scoreStep;
        }
    }
}
