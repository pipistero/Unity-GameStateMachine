using PS.GameStateMachine.Source.States;
using PS.GameStateMachine.Source.FSM;
using Zenject;

namespace PS.GameStateMachine.Source.Installers
{
    public class GameStateMachineInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
            Container.BindInterfacesAndSelfTo<RunningState>().AsSingle();
            Container.BindInterfacesAndSelfTo<FSM.GameStateMachine>().AsSingle().NonLazy();
        }
    }
}