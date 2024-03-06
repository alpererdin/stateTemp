using UnityEngine;

namespace _Scripts.Commands
{
    public class MoveCommand
    {
        private float _speed;
        private Transform _transform;

        public MoveCommand(Transform transform,float speed)
        {
            this._speed = speed;
            this._transform = transform;
        }
        
        public void Execute()
        {
            Vector3 newPosition = _transform.position + new Vector3(0, 0, _speed * Time.deltaTime);
            _transform.position = newPosition;
        }
    }
}