using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App.Battle.Interfaces
{
    public interface IBattleState
    {
        public IBattleState Execute();
        public IBattleState Cancel();
    }
}
