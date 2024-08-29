using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugStateUseCase : IInitializable, IDisposable
    {
        private readonly IBattleStateMachineUseCase _battleStateMachineUseCase;
        private readonly IBattleDebugStatePresenter _battleDebugStatePresenter;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugStateUseCase(
            IBattleStateMachineUseCase battleStateMachineUseCase,
            IBattleDebugStatePresenter battleDebugStatePresenter
        )
        {
            _battleStateMachineUseCase = battleStateMachineUseCase;
            _battleDebugStatePresenter = battleDebugStatePresenter;
        }

        public void Initialize()
        {
            _battleDebugStatePresenter.OnExecuteState
                .Subscribe(x => _battleStateMachineUseCase.Execute())
                .AddTo(_disposables);
            _battleDebugStatePresenter.OnCancelState
                .Subscribe(x => _battleStateMachineUseCase.Cancel())
                .AddTo(_disposables);
            _battleDebugStatePresenter.OnIncreaseStateIndex
                .Subscribe(x => _battleStateMachineUseCase.IncreaseIndex())
                .AddTo(_disposables);
            _battleDebugStatePresenter.OnDecreaseStateIndex
                .Subscribe(x => _battleStateMachineUseCase.DecreaseIndex())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}