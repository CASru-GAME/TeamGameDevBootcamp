using App.Common.Data;
using App.Battle.Interfaces.UseCases;
using App.Battle.Interfaces.Datastores;
using App.Battle.Datastores;
using VContainer;
using VContainer.Unity;

namespace App.Battle.UseCases
{
    public class BattleEnemyUseCase : IBattleEnemyUseCase
    {
        private readonly IBattleEnemyDatastore _BattleEnemyDatastore;

        [Inject]
        public BattleEnemyUseCase(
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
