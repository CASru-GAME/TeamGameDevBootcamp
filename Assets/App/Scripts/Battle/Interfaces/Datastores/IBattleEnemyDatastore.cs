using App.Battle.Data;
using App.Common.Data;
using System.Collections.Generic;

namespace App.Battle.Interfaces.Datastores
{
    public interface IBattleEnemyDatastore
    {
        IEnumerable<Enemy> Enemies { get; }
        void AddEnemy(string id, CharacterParameter characterParameter);
        void RemoveEnemy(string id);
        Enemy GetEnemyBy(string id);
    }
}