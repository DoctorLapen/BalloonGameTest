
using UnityEngine;

namespace BalloonGameTest
{
    public class WinHandler : MonoBehaviour
    {
        [SerializeField]
        private ScoreCounter _scoreCounter;
        [SerializeField]
        private int _scoreToWin;
        [SerializeField]
        private RectTransform _winUI;
        public int ScoreToWin => _scoreToWin;

        private void Start()
        {
            _scoreCounter.ScoreUpdated += CheckWin;
        }

      
        private void CheckWin(int score)
        {
            if (_scoreToWin == score)
            {
                _winUI.gameObject.SetActive(true);
            }
        }
    }
}
