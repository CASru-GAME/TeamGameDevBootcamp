using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using App.Battle.Interfaces;

namespace App.Battle.Presenters
{
    public class BattleStateItemsTargetPresenter : IBattleState
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
            UnityEngine.Debug.Log("CurrentState: Select Item");
            return new BattleStateItemsPresenter();
        }

        public IBattleState Cancel()
        {
            UnityEngine.Debug.Log("CurrentState: Select Item");
            return new BattleStateItemsPresenter();
        }
    }
}