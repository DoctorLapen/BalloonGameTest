using System.Collections;
using System.Collections.Generic;
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

        private void Start()
        {
            _text.text = _startText;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void UpdateText(int score) 
        {
            _text.text = score.ToString();
        }
    }
}
