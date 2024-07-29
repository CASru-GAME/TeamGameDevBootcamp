using App.Battle.Data;

namespace App.Battle.Datastores
{
    public class BattleEnemyDatastore
    {
        public Enemy Enemy { get; private set; }

        public BattleEnemyDatastore(Enemy enemy)
        {
            Enemy = enemy;
        }
    }
}