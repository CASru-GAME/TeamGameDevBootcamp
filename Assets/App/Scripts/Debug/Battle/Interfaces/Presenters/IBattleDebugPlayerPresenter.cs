using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugPlayerPresenter
    {
        IObservable<Unit> OnGeneratePlayer { get; }
    }
}
