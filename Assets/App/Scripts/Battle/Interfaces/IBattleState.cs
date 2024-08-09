using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App.Battle.Interfaces
{
    public interface IBattleState
    {
        public void IncreaseIndex();
        public void DecreaseIndex();
        public IBattleState Execute();
        public IBattleState Cancel();
    }
}
