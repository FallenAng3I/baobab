using TMPro;
using UnityEngine;

namespace _Source.CP2.ScoreSystem
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        private Score _score;

        public void Bind()
        {
            _score.OnScoreChange += DrawScore;
        }
        
        private void DrawScore()
        {
            scoreText.text = $"{_score.ScoreValue}";
        }

        public void Expose()
        {
            _score.OnScoreChange -= DrawScore;
        }
    }
}