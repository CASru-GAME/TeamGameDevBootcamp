using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugDecreaseStateIndexUseCase : IInitializable, IDisposable
    {
        private readonly IBattleDebugDecreaseStateIndexPresenter _battleDebugDecreaseStateIndexPresenter;
        private readonly IBattleStateMachineUseCase _battleStateMachineUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugDecreaseStateIndexUseCase(
            IBattleStateMachineUseCase battleStateMachineUseCase,
            IBattleDebugDecreaseStateIndexPresenter battleDebugDecreaseStateIndexPresenter
        )
        {
            _battleStateMachineUseCase = battleStateMachineUseCase;
            _battleDebugDecreaseStateIndexPresenter = battleDebugDecreaseStateIndexPresenter;
        }

        public void Initialize()
        {
            _battleDebugDecreaseStateIndexPresenter.OnDecreaseStateIndex
                .Subscribe(x => _battleStateMachineUseCase.DecreaseIndex())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}