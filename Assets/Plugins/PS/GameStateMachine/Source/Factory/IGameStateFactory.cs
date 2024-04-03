namespace PS.GameStateMachine
{
    public interface IGameStateFactory
    {
        TState GetState<TState>() where TState : class, IExitableState;
    }
}