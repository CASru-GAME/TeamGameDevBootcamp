using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Unity;

namespace App.Debug.Battle.Presenters
{
    public class BattleDebugStatePresenter : MonoBehaviour, IBattleDebugStatePresenter, IInitializable, IDisposable
    {
        [Header("ExecuteState")]
        [SerializeField] private Button _executeStateButton;
        private readonly Subject<Unit> _onExecuteState = new();
        public IObservable<Unit> OnExecuteState => _onExecuteState;

        [Header("CancelState")]
        [SerializeField] private Button _cancelStateButton;
        private readonly Subject<Unit> _onCancelState = new();
        public IObservable<Unit> OnCancelState => _onCancelState;

        [Header("IncreaseStateIndex")]
        [SerializeField] private Button _increaseStateIndexButton;
        private readonly Subject<Unit> _onIncreaseStateIndex = new();
        public IObservable<Unit> OnIncreaseStateIndex => _onIncreaseStateIndex;

        [Header("DecreaseStateIndex")]
        [SerializeField] private Button _decreaseStateIndexButton;
        private readonly Subject<Unit> _onDecreaseStateIndex = new();
        public IObservable<Unit> OnDecreaseStateIndex => _onDecreaseStateIndex;

        private readonly CompositeDisposable _disposables = new();

        public void Initialize()
        {
            _executeStateButton.OnClickAsObservable()
            .Subscribe(_ => _onExecuteState.OnNext(Unit.Default))
            .AddTo(_disposables);
            _cancelStateButton.OnClickAsObservable()
            .Subscribe(_ => _onCancelState.OnNext(Unit.Default))
            .AddTo(_disposables);
            _increaseStateIndexButton.OnClickAsObservable()
            .Subscribe(_ => _onIncreaseStateIndex.OnNext(Unit.Default))
            .AddTo(_disposables);
            _decreaseStateIndexButton.OnClickAsObservable()
            .Subscribe(_ => _onDecreaseStateIndex.OnNext(Unit.Default))
            .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}