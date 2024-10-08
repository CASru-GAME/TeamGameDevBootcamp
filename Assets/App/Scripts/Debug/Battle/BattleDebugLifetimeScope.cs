using App.Debug.Battle.Presenters;
using App.Debug.Battle.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle
{
    public class BattleDebugLifetimeScope : LifetimeScope
    {
        [SerializeField] private BattleDebugEnemyPresenter _BattleDebugEnemyPresenter;
        [SerializeField] private BattleDebugStatePresenter _BattleDebugStatePresenter;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_BattleDebugEnemyPresenter).AsImplementedInterfaces();
            builder.RegisterEntryPoint<BattleDebugEnemyUseCase>();
            builder.RegisterComponent(_BattleDebugStatePresenter).AsImplementedInterfaces();
            builder.RegisterEntryPoint<BattleDebugStateUseCase>();
        }
    }
}
