using ModestTree;
using PS.FSM.States;

namespace PS.FSM
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly IGameStateFactory _gameStateFactory;
        
        private IExitableState _activeState;

        public GameStateMachine(IGameStateFactory gameStateFactory)
        {
            _gameStateFactory = gameStateFactory;
        }
        
        public void Enter<TState>() where TState : class, IState
        {
            var state = ChangeState<TState>();
            state.Enter();
        }

        public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>
        {
            var state = ChangeState<TState>();
            state.Enter(payload);
        }

        private TState ChangeState<TState>() where TState : class, IExitableState
        {
            _activeState?.Exit();

            var state = GetState<TState>();
            _activeState = state;

            return state;
        }
        
        private TState GetState<TState>() where TState : class, IExitableState
        {
            return _gameStateFactory.GetState<TState>();
        }
    }
}