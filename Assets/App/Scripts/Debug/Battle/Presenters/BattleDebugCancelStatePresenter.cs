using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Unity;

namespace App.Debug.Battle.Presenters
{
    public class BattleDebugCancelStatePresenter : MonoBehaviour, IBattleDebugCancelStatePresenter, IInitializable, IDisposable
    {
        [Header("CancelState")]
        [SerializeField] private Button _cancelStateButton;

        private readonly Subject<Unit> _onCancelState = new();
        public IObservable<Unit> OnCancelState => _onCancelState;

        private readonly CompositeDisposable _disposables = new();
        public void Initialize()
        {
            _cancelStateButton.OnClickAsObservable()
            .Subscribe(_ => _onCancelState.OnNext(Unit.Default))
            .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}