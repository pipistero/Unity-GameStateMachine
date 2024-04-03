using UnityEngine;

namespace PS.GameStateMachine.Source.States
{
    public class BootstrapState : IState
    {
        public void Exit()
        {
            Debug.Log("Bootstrap state exit");
        }

        public void Enter()
        {
            Debug.Log("Bootstrap state enter");
        }
    }
}