using App.Battle.Datastores;
using App.Battle.UseCases;
using App.Battle.Presenters;
using App.Battle.Interfaces.UseCases;
using App.Battle.Interfaces.Datastores;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class BattleLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<BattleEnemyDatastore>(Lifetime.Singleton).AsImplementedInterfaces();
        builder.Register<BattleEnemyUseCase>(Lifetime.Singleton).AsImplementedInterfaces();
        builder.Register<BattlePlayerDatastore>(Lifetime.Singleton).AsImplementedInterfaces();
        builder.Register<BattlePlayerUseCase>(Lifetime.Singleton).AsImplementedInterfaces();
        builder.Register<BattleStateMachineUseCase>(Lifetime.Singleton).AsImplementedInterfaces();
        builder.Register<BattleStateMachinePresenter>(Lifetime.Singleton).AsImplementedInterfaces();
    }
}
