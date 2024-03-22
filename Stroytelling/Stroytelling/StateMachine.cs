﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal class StateMachine
    {
        private IState curState = null;
        public StateMachine()
        {
            Start();
        }

        private void Start()
        {
            curState = new Innenhof();
        }

        public void Update()
        {
            IState nextState = curState.Check();
            if (nextState != null)
            {
                curState.EndState();
                curState = nextState;
                curState.StartState();
            }
            curState.Update();
        }
    }
}