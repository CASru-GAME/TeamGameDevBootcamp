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
        private readonly IBattleDebugEnemyPresenter _battleDebugEnemyPresenter;
        private readonly IBattleEnemyGenerateUseCase _battleEnemyGenerateUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugEnemyUseCase(
            IBattleEnemyGenerateUseCase battleEnemyGenerateUseCase,
            IBattleDebugEnemyPresenter battleDebugEnemyPresenter
        )
        {
            _battleEnemyGenerateUseCase = battleEnemyGenerateUseCase;
            _battleDebugEnemyPresenter = battleDebugEnemyPresenter;
        }

        public void Initialize()
        {
            _battleDebugEnemyPresenter.OnGenerateEnemy
                .Subscribe(x => _battleEnemyGenerateUseCase.GenerateEnemy())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
