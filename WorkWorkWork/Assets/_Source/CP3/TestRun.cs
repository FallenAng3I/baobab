using CP3.AudioSystem;
using UnityEngine;

namespace CP3
{
    public class TestRun : MonoBehaviour
    {
        private void Start()
        {
            AudioPlayerSingleton.Instance.PlaySound();
        }
    }
}
