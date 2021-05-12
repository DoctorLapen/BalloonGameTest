
using UnityEngine;
using UnityEngine.UI;

namespace BalloonGameTest
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        [SerializeField]
        private string _startText;
        [SerializeField]
        private WinHandler _endGameHandler;

        private void Start()
        {
            _text.text = $"{ _startText } / { _endGameHandler.ScoreToWin }";
        }

        public void UpdateText(int score)
        {
            _text.text = $"{ score } / { _endGameHandler.ScoreToWin }";
        }
    }
}
