using System;
using System.Collections.Generic;
using System.Linq;
using PS.GameStateMachine.Source.States;
using UnityEngine;

namespace PS.GameStateMachine.Source.FSM
{
    public class GameStateMachine : IGameStateMachine
    {
        private Dictionary<Type, IExitableState> _states;
        private IState _activeState;

        public GameStateMachine(IEnumerable<IExitableState> states)
        {
            Debug.Log(states.Count());
        }
        
        public void Enter<TState>() where TState : class, IState
        {
            
        }

        public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>
        {
            
        }
    }
}