using PS.GameStateMachine;
using UnityEngine;
using Zenject;

namespace PS.GameBootstrapper
{
    public class GameBootstrapper : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;

        [Inject]
        private void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void Awake()
        {
            _gameStateMachine.Enter<BootstrapState>();
        }
    }
}