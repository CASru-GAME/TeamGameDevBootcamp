using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Unity;

namespace App.Debug.Battle.Presenters
{
    public class BattleDebugPlayerPresenter : MonoBehaviour, IBattleDebugPlayerPresenter, IInitializable, IDisposable
    {
        [Header("Player")]
        [SerializeField] private Button _generatePlayerButton;

        private readonly Subject<Unit> _onGeneratePlayer = new();
        public IObservable<Unit> OnGeneratePlayer => _onGeneratePlayer;

        private readonly CompositeDisposable _disposables = new();
        public void Initialize()
        {
            _generatePlayerButton.OnClickAsObservable()
            .Subscribe(_ => _onGeneratePlayer.OnNext(Unit.Default))
            .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
