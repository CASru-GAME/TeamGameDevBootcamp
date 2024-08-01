using App.Debug.Battle.Presenters;
using App.Debug.Battle.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle
{
    public class BattleDebugLifetimeScope : LifetimeScope
    {
        [SerializeField] private BattleDebugEnemyGeneratePresenter _battleDebugEnemyGeneratePresenter;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_battleDebugEnemyGeneratePresenter).AsImplementedInterfaces();

            builder.RegisterEntryPoint<BattleDebugEnemyGenerateUseCase>();
        }
    }
}
