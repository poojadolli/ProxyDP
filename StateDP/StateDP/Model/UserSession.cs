using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP.Model
{
    class UserSession
    {
        private IUserSessionState currentState;

        public UserSession()
        {
            currentState = new LockedState();
        }

        public void SetState(IUserSessionState newState)
        {
            currentState = newState;
        }
        public void ChangeState()
        {
            currentState.ChangeState(this);
        }
        
    }
    }
