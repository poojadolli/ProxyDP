using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP.Model
{
    class LoggedInState : IUserSessionState
    {
       
     

       

        public void ChangeState(UserSession usersession)
        {

            Console.WriteLine("Login Successfull");
            Thread.Sleep(1000);
            usersession.SetState(new LoggedOutState());

        }
    }
}