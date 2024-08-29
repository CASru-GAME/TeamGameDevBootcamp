using App.Battle.Interfaces.UseCases;
using App.Battle.Interfaces.Presenters;
using App.Battle.Presenters;
using System;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace App.Battle.UseCases
{
    public class BattleStateMachineUseCase : IBattleStateMachineUseCase
    {
        private IBattleStateMachinePresenter _BattleStateMachinePresenter;

        [Inject]
        public BattleStateMachineUseCase(
            IBattleStateMachinePresenter battleStateMachinePresenter
        )
        {
            _BattleStateMachinePresenter = battleStateMachinePresenter;
        }

        public void IncreaseIndex()
        {
            _BattleStateMachinePresenter.IncreaseIndex();
        }

        public void DecreaseIndex()
        {
            _BattleStateMachinePresenter.DecreaseIndex();
        }

        public void Execute()
        {
            _BattleStateMachinePresenter.Execute();
        }

        public void Cancel()
        {
            _BattleStateMachinePresenter.Cancel();     
        }
    }
}