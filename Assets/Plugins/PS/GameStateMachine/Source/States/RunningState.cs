using UnityEngine;

namespace PS.GameStateMachine.Source.States
{
    public class RunningState : IState
    {
        public void Exit()
        {
            Debug.Log("Running state exit");
        }

        public void Enter()
        {
            Debug.Log("Running state enter");
        }
    }
}