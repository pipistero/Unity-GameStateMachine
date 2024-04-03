using PS.FSM.States;
using UnityEngine;
using Zenject;

namespace PS.FSM
{
    public class GameBootstrapper : MonoBehaviour
    {
        private GameStateMachine _gameStateMachine;

        [Inject]
        private void Construct(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}