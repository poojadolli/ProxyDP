using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP.Model
{
    interface IUserSessionState
    {
        void ChangeState(UserSession usersession);
       
    }
}
