using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using App.Battle.Interfaces;

namespace App.Battle.Presenters
{
    public class BattleStateItemsPresenter : IBattleState
    {
        public void IncreaseIndex()
        {
            UnityEngine.Debug.Log("CurrentIndex: 0");
            return;
        }

        public void DecreaseIndex()
        {
            UnityEngine.Debug.Log("CurrentIndex: 0");
            return;
        }

        public IBattleState Execute()
        {
            UnityEngine.Debug.Log("CurrentState: Select Target(Item)");
            return new BattleStateItemsTargetPresenter();
        }

        public IBattleState Cancel()
        {
            UnityEngine.Debug.Log("CurrentState: Select Command");
            return new BattleStateFirstPresenter();
        }
    }
}