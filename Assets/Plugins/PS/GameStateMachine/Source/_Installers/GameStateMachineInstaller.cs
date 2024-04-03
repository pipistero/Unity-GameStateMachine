using Zenject;

namespace PS.GameStateMachine
{
    public class GameStateMachineInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallGameStateFactory();
            InstallGameStateMachine();
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