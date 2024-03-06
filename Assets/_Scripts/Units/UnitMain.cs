using System;
using System.Collections.Generic;
using States;
using UnityEngine;
namespace Units
{
    [Serializable]
    public abstract class UnitMain :MonoBehaviour
    {
        public BaseState CurrentState;
        internal float Speed; 
        protected virtual void Start()
        {
            if (CurrentState == null)
            {
                SetUnitState(UnitStateFactory.MoveState());
            }
        }
        public void SetUnitState(BaseState newState)
        {
            CurrentState?.ExitState();
            CurrentState = newState;
            CurrentState.EnterState(this);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("GoBackCollider"))
            {
                Speed *= -1;
            }
        }
    }
}