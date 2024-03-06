using _Scripts.Commands;
using Units;
using UnityEngine;
namespace States
{
    public class MoveState : BaseState
    { 
        public override UnitStateType Type => UnitStateType.Move;
        private UnitMain _unit;
        public override void EnterState(UnitMain unit)
        {
            this._unit = unit;
            //_unit._anim.SetTrigger("RunA");
        }
        public override void UpdateState()
        {
            /* if (_unit.CurrentState.Type!=UnitStateType.Move)
            {
                _unit.SetUnitState(UnitStateFactory.MoveState());
            }*/
            PlayerMove();
        }
        void PlayerMove()
        {
            MoveCommand moveCommand = MoveCommandFactory.ZMovementCommand(_unit.transform, _unit.Speed);
            moveCommand.Execute();
        }
        public override void FixedUpdate() { }
        public override void ExitState() { }
    }
}