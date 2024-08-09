namespace App.Battle.Interfaces.UseCases
{
    public interface IBattleStateMachineUseCase
    {
        public void IncreaseIndex();
        public void DecreaseIndex();
        public void Execute();
        public void Cancel();
    }
}
