using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugStatePresenter
    {
        IObservable<Unit> OnExecuteState { get; }
        IObservable<Unit> OnCancelState { get; }
        IObservable<Unit> OnIncreaseStateIndex { get; }
        IObservable<Unit> OnDecreaseStateIndex { get; }
    }
}
