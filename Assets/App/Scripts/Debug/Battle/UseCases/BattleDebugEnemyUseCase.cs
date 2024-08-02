using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugEnemyUseCase : IInitializable, IDisposable
    {
        private readonly IBattleDebugEnemyPresenter _BattleDebugEnemyPresenter;
        private readonly IBattleEnemyUseCase _BattleEnemyUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugEnemyUseCase(
            IBattleEnemyUseCase battleEnemyUseCase,
            IBattleDebugEnemyPresenter battleDebugEnemyPresenter
        )
        {
            _BattleEnemyUseCase = battleEnemyUseCase;
            _BattleDebugEnemyPresenter = battleDebugEnemyPresenter;
        }

        public void Initialize()
        {
            _BattleDebugEnemyPresenter.OnGenerateEnemy
                .Subscribe(x => _BattleEnemyUseCase.GenerateEnemy())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
