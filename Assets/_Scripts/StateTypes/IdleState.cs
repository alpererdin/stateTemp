using Units;
using UnityEngine;
namespace States
{
    public class IdleState : BaseState
    {
        public override UnitStateType Type => UnitStateType.Idle;
        private UnitMain _unit;
        public override void EnterState(UnitMain unit)
        {
            this._unit = unit;
            //_unit._anim.SetTrigger("IdleA");
        }
        public override void UpdateState() { }
        public override void FixedUpdate() { }
        public override void ExitState() { }
    }
}