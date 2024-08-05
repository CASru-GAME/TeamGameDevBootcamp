using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using App.Battle.Interfaces;

namespace App.Battle.Presenters
{
    public class BattleStateMachinePresenter
    {
        private IBattleState _currentState = new BattleStateFirstPresenter();

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