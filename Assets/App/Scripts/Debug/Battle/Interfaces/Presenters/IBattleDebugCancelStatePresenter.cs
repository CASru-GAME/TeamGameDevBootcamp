using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugCancelStatePresenter
    {
        IObservable<Unit> OnCancelState { get; }
    }
}
