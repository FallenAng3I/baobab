using CP2.InputSystem;
using CP2.ScoreSystem;
using UnityEngine;

namespace CP2.Core
{
    public class BootStrapper : MonoBehaviour
    {
        [SerializeField] private InputListener inputListener;
        [SerializeField] private ClickableItem clickItem;
        [SerializeField] private MovingClickableItem mClickItem;
        [SerializeField] private ScoreView scoreView;
        private Game _game;
        private Score _score;

        private void Awake()
        {
            _score = new();
            _game = new(_score);
            inputListener.Construct(_game);
            clickItem.Construct(_score);
            mClickItem.Construct(_score);
            scoreView.Construct(_score);
            

            scoreView.Bind();
            _game.StartGame();
        }
    }
}
