using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugIncreaseStateIndexUseCase : IInitializable, IDisposable
    {
        private readonly IBattleDebugIncreaseStateIndexPresenter _battleDebugIncreaseStateIndexPresenter;
        private readonly IBattleStateMachineUseCase _battleStateMachineUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugIncreaseStateIndexUseCase(
            IBattleStateMachineUseCase battleStateMachineUseCase,
            IBattleDebugIncreaseStateIndexPresenter battleDebugIncreaseStateIndexPresenter
        )
        {
            _battleStateMachineUseCase = battleStateMachineUseCase;
            _battleDebugIncreaseStateIndexPresenter = battleDebugIncreaseStateIndexPresenter;
        }

        public void Initialize()
        {
            _battleDebugIncreaseStateIndexPresenter.OnIncreaseStateIndex
                .Subscribe(x => _battleStateMachineUseCase.IncreaseIndex())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}