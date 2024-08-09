using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugCancelStateUseCase : IInitializable, IDisposable
    {
        private readonly IBattleDebugCancelStatePresenter _battleDebugCancelStatePresenter;
        private readonly IBattleStateMachineUseCase _battleStateMachineUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugCancelStateUseCase(
            IBattleStateMachineUseCase battleStateMachineUseCase,
            IBattleDebugCancelStatePresenter battleDebugCancelStatePresenter
        )
        {
            _battleStateMachineUseCase = battleStateMachineUseCase;
            _battleDebugCancelStatePresenter = battleDebugCancelStatePresenter;
        }

        public void Initialize()
        {
            _battleDebugCancelStatePresenter.OnCancelState
                .Subscribe(x => _battleStateMachineUseCase.Cancel())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}