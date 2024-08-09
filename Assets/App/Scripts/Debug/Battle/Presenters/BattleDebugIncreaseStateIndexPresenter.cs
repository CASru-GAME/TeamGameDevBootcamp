using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Unity;

namespace App.Debug.Battle.Presenters
{
    public class BattleDebugIncreaseStateIndexPresenter : MonoBehaviour, IBattleDebugIncreaseStateIndexPresenter, IInitializable, IDisposable
    {
        [Header("IncreaseStateIndex")]
        [SerializeField] private Button _increaseStateIndexButton;

        private readonly Subject<Unit> _onIncreaseStateIndex = new();
        public IObservable<Unit> OnIncreaseStateIndex => _onIncreaseStateIndex;

        private readonly CompositeDisposable _disposables = new();
        public void Initialize()
        {
            _increaseStateIndexButton.OnClickAsObservable()
            .Subscribe(_ => _onIncreaseStateIndex.OnNext(Unit.Default))
            .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}