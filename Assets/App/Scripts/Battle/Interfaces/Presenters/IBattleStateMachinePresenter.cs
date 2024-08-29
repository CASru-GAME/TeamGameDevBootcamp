namespace App.Battle.Interfaces.Presenters
{
    public interface IBattleStateMachinePresenter
    {
        public void IncreaseIndex();
        public void DecreaseIndex();
        public void Execute();
        public void Cancel();
    }
}
