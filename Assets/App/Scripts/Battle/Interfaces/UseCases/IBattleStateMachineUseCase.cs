namespace App.Battle.Interfaces.UseCases
{
    public interface IBattleStateMachineUseCase
    {
        public void Execute();
        void Cancel();
    }
}
