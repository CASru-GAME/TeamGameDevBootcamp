using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Unity;

namespace App.Debug.Battle.Presenters
{
    public class BattleDebugEnemyGeneratePresenter : MonoBehaviour, IBattleDebugEnemyPresenter, IInitializable, IDisposable
    {
        [Header("Enemy")]
        [SerializeField] private Button _generateEnemyButton;

        private readonly Subject<Unit> _onGenerateEnemy = new();
        public IObservable<Unit> OnGenerateEnemy => _onGenerateEnemy;

        private readonly CompositeDisposable _disposables = new();
        public void Initialize()
        {
            _generateEnemyButton.OnClickAsObservable()
            .Subscribe(_ => _onGenerateEnemy.OnNext(Unit.Default))
            .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}