using App.Battle.Interfaces.UseCases;
using App.Debug.Battle.Interfaces.Presenters;
using App.Battle.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Battle.UseCases
{
    public class BattleStateMachineUseCase : IBattleStateMachineUseCase
    {
        private BattleStateMachinePresenter _battleStateMachinePresenter = new BattleStateMachinePresenter();

        public void IncreaseIndex()
        {
            _battleStateMachinePresenter.IncreaseIndex();
        }

        public void DecreaseIndex()
        {
            _battleStateMachinePresenter.DecreaseIndex();
        }

        public void Execute()
        {
            _battleStateMachinePresenter.Execute();
        }

        public void Cancel()
        {
            _battleStateMachinePresenter.Cancel();     
        }
    }
}