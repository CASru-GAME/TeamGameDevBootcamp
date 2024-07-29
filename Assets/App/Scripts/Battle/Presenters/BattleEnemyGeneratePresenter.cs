using App.Common.Data;
using App.Battle.Interfaces.Datastores;
using App.Battle.Datastores;
using VContainer;
using VContainer.Unity;

namespace App.Battle.Presenters
{
    public class BattleEnemyGeneratePresenter
    {
        private readonly IBattleEnemyDatastore _BattleEnemyDatastore;

        [Inject]
        public BattleEnemyGeneratePresenter(
            IBattleEnemyDatastore battleEnemyDatastore
        )
        {
            _BattleEnemyDatastore = battleEnemyDatastore;
        }

        public void GenerateEnemy()
        {
            _BattleEnemyDatastore.AddEnemy("1", new CharacterParameter());
            UnityEngine.Debug.Log($"{"1"} generated");
        }
    }
}