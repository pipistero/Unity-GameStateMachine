using Zenject;

namespace PS.FSM
{
    public class GameStateMachineInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallGameStateFactory();
            InstallGameStateMachine();
            InstallStates();
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
        
        private void InstallStates()
        {
            
        }
    }
}