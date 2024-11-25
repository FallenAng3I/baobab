using UnityEngine;

namespace CP2.ScoreSystem
{
    public class MovingClickableItem : MonoBehaviour
    {
        private Score _score;
        private HingeJoint _hingeJoint;

        public void Construct(Score score)
        {
            _score = score;
            _hingeJoint = GetComponent<HingeJoint>();
            SetupMotor();
        }

        private void OnMouseDown()
        {
            _score.AddScore(1);
        }

        private void SetupMotor()
        {
            if (_hingeJoint != null)
            {
                var motor = _hingeJoint.motor;
                motor.force = 10;
                motor.targetVelocity = 50; // speed
                motor.freeSpin = false;
                _hingeJoint.motor = motor;
                _hingeJoint.useMotor = true;
            }
        }
    }
}