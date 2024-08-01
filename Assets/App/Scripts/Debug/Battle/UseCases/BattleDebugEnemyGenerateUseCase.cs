using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugEnemyGenerateUseCase : IInitializable, IDisposable
    {
        private readonly IBattleDebugEnemyGeneratePresenter _battleDebugEnemyGeneratePresenter;
        private readonly IBattleEnemyGenerateUseCase _battleEnemyGenerateUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugEnemyGenerateUseCase(
            IBattleEnemyGenerateUseCase battleEnemyGenerateUseCase,
            IBattleDebugEnemyGeneratePresenter battleDebugEnemyPresenter
        )
        {
            _battleEnemyGenerateUseCase = battleEnemyGenerateUseCase;
            _battleDebugEnemyGeneratePresenter = battleDebugEnemyPresenter;
        }

        public void Initialize()
        {
            _battleDebugEnemyGeneratePresenter.OnGenerateEnemy
                .Subscribe(x => _battleEnemyGenerateUseCase.GenerateEnemy())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
