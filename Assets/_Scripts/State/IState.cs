using Units;

namespace States
{
    public abstract class IState
    {
        public abstract void EnterState(UnitMain unit);

        public abstract void UpdateState();

        public abstract void FixedUpdate();

        public abstract void ExitState();
        
    }
}