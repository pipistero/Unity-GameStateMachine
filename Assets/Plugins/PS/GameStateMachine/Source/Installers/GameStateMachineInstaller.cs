using Zenject;

namespace PS.GameStateMachine
{
    public class GameStateMachineInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallGameStateFactory();
            InstallGameStateMachine();
            InstallStates();
        }

        private void InstallStates()
        {
            // Install your states here
            InstallState<BootstrapState>();
        }

        private void InstallState<TState>() where TState : class, IState
        {
            Container
                .Bind<TState>()
                .AsSingle();
        }

        private void InstallGameStateFactory()
        {
            Container
                .BindInterfacesAndSelfTo<GameStateFactory>()
                .AsSingle();
        }

        private void InstallGameStateMachine()
        {
            Container
                .BindInterfacesAndSelfTo<GameStateMachine>()
                .AsSingle();
        }
    }
}