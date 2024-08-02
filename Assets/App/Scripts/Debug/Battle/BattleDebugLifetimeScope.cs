using App.Debug.Battle.Presenters;
using App.Debug.Battle.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle
{
    public class BattleDebugLifetimeScope : LifetimeScope
    {
        [SerializeField] private BattleDebugEnemyGeneratePresenter _BattleDebugEnemyGeneratePresenter;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_BattleDebugEnemyGeneratePresenter).AsImplementedInterfaces();

            builder.RegisterEntryPoint<BattleDebugEnemyGenerateUseCase>();
        }
    }
}
