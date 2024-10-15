using System;

namespace _Source.CP2.ScoreSystem
{
    public class Score
    {
        private int _scoreValue;

        public int ScoreValue
        {
            get => _scoreValue;
            private set
            {
                _scoreValue = value;
                OnScoreChange?.Invoke();
            }
        }

        public event Action OnScoreChange; 

        public void SetScore(int value)
        {
            ScoreValue = value;
        }

        public void AddScore(int value)
        {
            ScoreValue += value;
        }
    }
}
