using App.Debug.Battle.Presenters;
using App.Debug.Battle.UseCases;
using App.Battle.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle
{
    public class BattleDebugLifetimeScope : LifetimeScope
    {
        [SerializeField] private BattleDebugEnemyPresenter _BattleDebugEnemyPresenter;
        [SerializeField] private BattleDebugExecuteStatePresenter _BattleDebugExecuteStatePresenter;
        [SerializeField] private BattleDebugCancelStatePresenter _BattleDebugCancelStatePresenter;
        [SerializeField] private BattleDebugIncreaseStateIndexPresenter _BattleDebugIncreaseStateIndexPresenter;
        [SerializeField] private BattleDebugDecreaseStateIndexPresenter _BattleDebugDecreaseStateIndexPresenter;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_BattleDebugEnemyPresenter).AsImplementedInterfaces();

            builder.RegisterEntryPoint<BattleDebugEnemyUseCase>();

            builder.RegisterComponent(_BattleDebugExecuteStatePresenter).AsImplementedInterfaces();

            builder.RegisterEntryPoint<BattleDebugExecuteStateUseCase>();

            builder.RegisterComponent(_BattleDebugCancelStatePresenter).AsImplementedInterfaces();

            builder.RegisterEntryPoint<BattleDebugCancelStateUseCase>();

            builder.RegisterComponent(_BattleDebugIncreaseStateIndexPresenter).AsImplementedInterfaces();

            builder.RegisterEntryPoint<BattleDebugIncreaseStateIndexUseCase>();

            builder.RegisterComponent(_BattleDebugDecreaseStateIndexPresenter).AsImplementedInterfaces();

            builder.RegisterEntryPoint<BattleDebugDecreaseStateIndexUseCase>();

            builder.Register<BattleStateMachineUseCase>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}
