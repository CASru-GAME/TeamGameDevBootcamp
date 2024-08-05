using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using App.Battle.Interfaces;

namespace App.Battle.Presenters
{
    public class BattleStateSkillsPresenter : IBattleState
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
            UnityEngine.Debug.Log("CurrentState: Select Target(Skill)");
            return new BattleStateSkillsTargetPresenter();
        }

        public IBattleState Cancel()
        {
            UnityEngine.Debug.Log("CurrentState: Select Command");
            return new BattleStateFirstPresenter();
        }
    }
}