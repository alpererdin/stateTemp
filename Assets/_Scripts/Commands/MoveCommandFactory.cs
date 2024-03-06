using UnityEngine;

namespace _Scripts.Commands
{
    public class MoveCommandFactory
    {
        public static MoveCommand ZMovementCommand(Transform transform,float speed)
        {
            return new MoveCommand(transform,speed);
        }
    }
}