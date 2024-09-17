using App.Debug.Battle.Interfaces.Presenters;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Unity;

namespace App.Debug.Battle.Presenters
{
    public class BattleDebugUseSkillPresenter : MonoBehaviour, IBattleDebugUseSkillPresenter, IInitializable, IDisposable
    {
        [Header("Skill")]
        [SerializeField] private Button _useSkillButton1;

        private readonly Subject<Unit> _onUseSkill1 = new();
        public IObservable<Unit> OnUseSkill1 => _onUseSkill1;

        private readonly CompositeDisposable _disposables = new();
        public void Initialize()
        {
            _useSkillButton1.OnClickAsObservable()
            .Subscribe(_ => _onUseSkill1.OnNext(Unit.Default))
            .AddTo(_disposables);
            UnityEngine.Debug.Log("BattleDebugUseSkillPresenter Initialized");
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
