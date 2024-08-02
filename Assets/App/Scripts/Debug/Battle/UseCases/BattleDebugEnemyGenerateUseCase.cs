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
        private readonly IBattleDebugEnemyGeneratePresenter _BattleDebugEnemyGeneratePresenter;
        private readonly IBattleEnemyGenerateUseCase _BattleEnemyGenerateUseCase;

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugEnemyGenerateUseCase(
            IBattleEnemyGenerateUseCase battleEnemyGenerateUseCase,
            IBattleDebugEnemyGeneratePresenter battleDebugEnemyPresenter
        )
        {
            _BattleEnemyGenerateUseCase = battleEnemyGenerateUseCase;
            _BattleDebugEnemyGeneratePresenter = battleDebugEnemyPresenter;
        }

        public void Initialize()
        {
            _BattleDebugEnemyGeneratePresenter.OnGenerateEnemy
                .Subscribe(x => _BattleEnemyGenerateUseCase.GenerateEnemy())
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
