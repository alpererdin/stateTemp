namespace States
{
    public abstract class BaseState : IState
    {
        public abstract UnitStateType Type { get; }
        
    }

    public enum UnitStateType
    {
        None,Idle,Move,//Add here
    }
}