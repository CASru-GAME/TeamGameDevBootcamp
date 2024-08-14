using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using App.Battle.Interfaces;
using App.Battle.Interfaces.Presenters;

namespace App.Battle.Presenters
{
    public class BattleStateMachinePresenter : IBattleStateMachinePresenter
    {
        private IBattleState _currentState = new BattleStateFirstPresenter();

        public void IncreaseIndex()
        {
            if(_currentState == null)
            {
                throw new System.Exception("CurrentState is null");
            }
            _currentState.IncreaseIndex();
        }

        public void DecreaseIndex()
        {
            if(_currentState == null)
            {
                throw new System.Exception("CurrentState is null");
            }
            _currentState.DecreaseIndex();
        }

        public void Execute()
        {
            if(_currentState == null)
            {
                throw new System.Exception("CurrentState is null");
            }
            _currentState = _currentState.Execute();
        }

        public void Cancel()
        {
            _currentState = _currentState.Cancel();
        }
    }
}