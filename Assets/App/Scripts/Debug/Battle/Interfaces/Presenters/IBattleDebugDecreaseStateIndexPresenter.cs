using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugDecreaseStateIndexPresenter
    {
        IObservable<Unit> OnDecreaseStateIndex { get; }
    }
}
