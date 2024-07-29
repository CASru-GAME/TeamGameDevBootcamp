using App.Battle.Datastores;
using App.Battle.UseCases;
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

        builder.RegisterEntryPoint<BattleEnemyGenerateUseCase>();
    }
}
