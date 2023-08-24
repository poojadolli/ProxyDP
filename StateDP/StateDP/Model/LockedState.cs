using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP.Model
{
    class LockedState : IUserSessionState
    {  public void ChangeState(UserSession usersession)
        {
            Console.WriteLine("Session is Locked! Please Login");
            Thread.Sleep(1000);
            usersession.SetState(new LoggedInState());
        }
    }
    }
