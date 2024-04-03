using PS.FSM.States;

namespace PS.FSM
{
    public interface IGameStateFactory
    {
        TState GetState<TState>() where TState : class, IExitableState;
    }
}