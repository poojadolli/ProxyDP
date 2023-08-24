using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP.Model
{
    class LoggedOutState : IUserSessionState
    {
       
        public void ChangeState(UserSession usersession)
        {

            Console.WriteLine("Logged Out");
            Thread.Sleep(1000);
            usersession.SetState(new LockedState());


            }
        }
    }
