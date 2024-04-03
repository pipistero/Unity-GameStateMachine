using PS.GameStateMachine.Source.States;
using Zenject;

namespace Plugins.PS.GameStateMachine.Source
{
    public class Test
    {
        private DiContainer _container;

        public IState Create<TState>() where TState : IState
        {
            return _container.Instantiate<TState>();
        }
    }
}