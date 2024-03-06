using System;

namespace Units
{
    public class UnitTypeOne : UnitMain
    {
        #region test
        //  public UnitData soldierData;
        /* protected override void Awake()
        {
           if (UnitData != null)
            {
                Speed = UnitData.unitSpeed;
            }
        }*/
        #endregion

        public float _Speed;
        private void Awake()
        {
            Speed = _Speed;
        }

        private void Update()
        {
            CurrentState?.UpdateState();
            
        }
        private void FixedUpdate()
        {
            CurrentState?.FixedUpdate();
        }
    
    }
}