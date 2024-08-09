using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugIncreaseStateIndexPresenter
    {
        IObservable<Unit> OnIncreaseStateIndex { get; }
    }
}