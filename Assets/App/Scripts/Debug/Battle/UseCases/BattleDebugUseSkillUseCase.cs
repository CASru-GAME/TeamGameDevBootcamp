using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using App.Common.Data;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Debug.Battle.UseCases
{
    public class BattleDebugUseSkillUseCase : IInitializable, IDisposable
    {
        private readonly IBattleDebugUseSkillPresenter _BattleDebugUseSkillPresenter;
        private readonly IBattleUseSkillUseCase _BattleUseSkillUseCase;

        private readonly CharacterParameter testPlayer = new CharacterParameter();

        private readonly CompositeDisposable _disposables = new();

        [Inject]
        public BattleDebugUseSkillUseCase(
            IBattleUseSkillUseCase battleUseSkillUseCase,
            IBattleDebugUseSkillPresenter battleDebugUseSkillPresenter
        )
        {
            _BattleUseSkillUseCase = battleUseSkillUseCase;
            _BattleDebugUseSkillPresenter = battleDebugUseSkillPresenter;
        }

        public void Initialize()
        {
            _BattleDebugUseSkillPresenter.OnUseSkill1
                .Subscribe(x => _BattleUseSkillUseCase.UseSkill(testPlayer, 1, 1))
                .AddTo(_disposables);
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
