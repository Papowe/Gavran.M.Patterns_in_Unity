using UnityEngine;

namespace Asteroid
{
    internal sealed class Ship : IMove, IRotation
    {
        private readonly IMove _moveInplementation;
        private readonly IRotation _rotationInplementation;

        public float Speed
        {
            get { return _moveInplementation.Speed; }
        }

        public Ship(IMove moveInplementation, IRotation rotationInplementation)
        {
            _moveInplementation = moveInplementation;
            _rotationInplementation = rotationInplementation;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveInplementation.Move(horizontal, vertical, deltaTime);
        }

        public void Rotation(Vector3 direction)
        {
            _rotationInplementation.Rotation(direction);
        }

        public void AddAcceleration()
        {
            if (_moveInplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }
        
        public void RemoveAcceleration()
        {
            if (_moveInplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }
    }
}