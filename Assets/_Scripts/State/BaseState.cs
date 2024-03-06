namespace States
{
    public abstract class BaseState : StateBase
    {
        public abstract UnitStateType Type { get; }
        
    }

    public enum UnitStateType
    {
        None,Idle,Move,//Add here
    }
}