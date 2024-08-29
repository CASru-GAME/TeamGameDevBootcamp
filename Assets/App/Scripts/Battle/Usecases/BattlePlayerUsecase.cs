using App.Common.Data;
using App.Battle.Interfaces.UseCases;
using App.Battle.Interfaces.Datastores;
using App.Battle.Datastores;
using VContainer;
using VContainer.Unity;

namespace App.Battle.UseCases
{
    public class BattlePlayerUseCase : IBattlePlayerUseCase
    {
        private readonly IBattlePlayerDatastore _BattlePlayerDatastore;

        [Inject]
        public BattlePlayerUseCase(
            IBattlePlayerDatastore battlePlayerDatastore
        )
        {
            _BattlePlayerDatastore = battlePlayerDatastore;
        }

        public void GeneratePlayer()
        {
            _BattlePlayerDatastore.AddPlayer("1", new CharacterParameter());
            UnityEngine.Debug.Log($"{"1"} generated");
        }
    }
}
