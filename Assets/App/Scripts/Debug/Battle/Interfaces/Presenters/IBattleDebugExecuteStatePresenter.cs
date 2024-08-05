using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugExecuteStatePresenter
    {
        IObservable<Unit> OnExecuteState { get; }
    }
}
