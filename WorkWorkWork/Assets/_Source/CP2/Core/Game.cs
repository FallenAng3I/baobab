using _Source.CP2.ScoreSystem;

namespace _Source.CP2.Core
{
    public class Game
    {
        private const int _startScoreValue = 15;
        private const int _finishScoreValue = 0;
        
        private readonly Score _score;
        
        public Game(Score score)
        {
            _score = score;
        }
        
        public void StartGame()
        {
            _score.SetScore(_startScoreValue);
        }

        public void FinishGame()
        {
            _score.SetScore(_finishScoreValue);
        }
    }
}
