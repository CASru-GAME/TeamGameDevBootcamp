using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugUseSkillPresenter
    {
        IObservable<Unit> OnUseSkill1 { get; }
    }
}
