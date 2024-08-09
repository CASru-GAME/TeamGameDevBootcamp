using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Unity;

namespace App.Debug.Battle.Presenters
{
    public class BattleDebugDecreaseStateIndexPresenter : MonoBehaviour, IBattleDebugDecreaseStateIndexPresenter, IInitializable, IDisposable
    {
        [Header("DecreaseStateIndex")]
        [SerializeField] private Button _decreaseStateIndexButton;

        private readonly Subject<Unit> _onDecreaseStateIndex = new();
        public IObservable<Unit> OnDecreaseStateIndex => _onDecreaseStateIndex;

        private readonly CompositeDisposable _disposables = new();
        public void Initialize()
        {
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