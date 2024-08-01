using System;
using UniRx;

namespace App.Debug.Battle.Interfaces.Presenters
{
    public interface IBattleDebugEnemyGeneratePresenter
    {
        IObservable<Unit> OnGenerateEnemy { get; }
    }
}