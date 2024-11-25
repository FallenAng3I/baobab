using UnityEngine;

namespace CP2.ScoreSystem
{
    public class ClickableItem : MonoBehaviour
    {
        private Score _score;

        public void Construct(Score score)
        {
            _score = score;
        }
        
        private void OnMouseDown()
        {
            _score.AddScore(-1);
        }

        private void SetupMotor(HingeJoint hg)
        {
            //hg.motor.targetVelocity = 0;
            var motor = hg.motor;
            motor.targetVelocity = 0; //  ||   motor.targetVelocity *= -1;
            hg.motor = motor;
        }
    }
}
