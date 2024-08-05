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
            return;
        }

        public void DecreaseIndex()
        {
            return;
        }

        public IBattleState Execute()
        {
            UnityEngine.Debug.Log("CurrentState: BattleStateItemsTargetPresenter");
            return new BattleStateItemsTargetPresenter();
        }

        public IBattleState Cancel()
        {
            UnityEngine.Debug.Log("CurrentState: BattleStateFirstPresenter");
            return new BattleStateFirstPresenter();
        }
    }
}