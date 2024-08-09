using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Unity;

namespace App.Debug.Battle.Presenters
{
    public class BattleDebugExecuteStatePresenter : MonoBehaviour, IBattleDebugExecuteStatePresenter, IInitializable, IDisposable
    {
        [Header("ExecuteState")]
        [SerializeField] private Button _executeStateButton;

        private readonly Subject<Unit> _onExecuteState = new();
        public IObservable<Unit> OnExecuteState => _onExecuteState;

        private readonly CompositeDisposable _disposables = new();
        public void Initialize()
        {
            _executeStateButton.OnClickAsObservable()
            .Subscribe(_ => _onExecuteState.OnNext(Unit.Default))
            .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}