using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using App.Battle.Interfaces;

namespace App.Battle.Presenters
{
    public class BattleStateFirstPresenter : IBattleState
    {
        private int _nextStateNumber = 3; 
        private int _nextStateIndex = 0;

        public void IncreaseIndex()
        {
            if(_nextStateIndex < _nextStateNumber - 1)
            {
                _nextStateIndex++;
            }
            UnityEngine.Debug.Log($"CurrentIndex: {_nextStateIndex}");
        }

        public void DecreaseIndex()
        {
            if(_nextStateIndex > 0)
            {
                _nextStateIndex--;
            }
            UnityEngine.Debug.Log($"CurrentIndex: {_nextStateIndex}");
        }

        public IBattleState Execute()
        {
            switch(_nextStateIndex)
            {
                case 0:
                    UnityEngine.Debug.Log("CurrentState: BattleStateSkillsPresenter");
                    return new BattleStateSkillsPresenter();
                case 1:
                    UnityEngine.Debug.Log("CurrentState: BattleStateFirstPresenter");
                    return this;
                case 2:
                    UnityEngine.Debug.Log("CurrentState: BattleStateItemsPresenter");
                    return new BattleStateItemsPresenter();
            }
            return null;
        }

        public IBattleState Cancel()
        {
            UnityEngine.Debug.Log("CurrentState: BattleStateFirstPresenter");
            return this;
        }
    }
}