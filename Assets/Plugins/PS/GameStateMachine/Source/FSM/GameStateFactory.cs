using PS.FSM.States;
using Zenject;

namespace PS.FSM
{
    public class GameStateFactory
    {
        private readonly DiContainer _container;

        public GameStateFactory(DiContainer container)
        {
            _container = container;
        }

        public TState GetState<TState>() where TState : class, IExitableState
        {
            return _container.Instantiate<TState>();
        }
    }
}