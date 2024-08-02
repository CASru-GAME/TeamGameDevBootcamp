using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugEnemyPresenter
    {
        IObservable<Unit> OnGenerateEnemy { get; }
    }
}
