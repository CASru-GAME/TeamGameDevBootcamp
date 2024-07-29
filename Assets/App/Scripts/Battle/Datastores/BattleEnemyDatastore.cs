using App.Battle.Data;
using System.Collections.Generic;
using UniRx;

namespace App.Battle.Datastores
{
    public class BattleEnemyDatastore
    {
        private ReactiveCollection<string> _enemyIds = new();
        public IEnumerable<string> EnemyIds => _enemyIds;
    }
}