using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugPlayerUseCase : IInitializable, IDisposable
    {
        private readonly IBattleDebugPlayerPresenter _BattleDebugPlayerPresenter;
        private readonly IBattlePlayerUseCase _BattlePlayerUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugPlayerUseCase(
            IBattlePlayerUseCase battlePlayerUseCase,
            IBattleDebugPlayerPresenter battleDebugPlayerPresenter
        )
        {
            _BattlePlayerUseCase = battlePlayerUseCase;
            _BattleDebugPlayerPresenter = battleDebugPlayerPresenter;
        }

        public void Initialize()
        {
            _BattleDebugPlayerPresenter.OnGeneratePlayer
                .Subscribe(x => _BattlePlayerUseCase.GeneratePlayer())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
