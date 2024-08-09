using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugExecuteStateUseCase : IInitializable, IDisposable
    {
        private readonly IBattleDebugExecuteStatePresenter _battleDebugExecuteStatePresenter;
        private readonly IBattleStateMachineUseCase _battleStateMachineUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugExecuteStateUseCase(
            IBattleStateMachineUseCase battleStateMachineUseCase,
            IBattleDebugExecuteStatePresenter battleDebugExecuteStatePresenter
        )
        {
            _battleStateMachineUseCase = battleStateMachineUseCase;
            _battleDebugExecuteStatePresenter = battleDebugExecuteStatePresenter;
        }

        public void Initialize()
        {
            _battleDebugExecuteStatePresenter.OnExecuteState
                .Subscribe(x => _battleStateMachineUseCase.Execute())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}