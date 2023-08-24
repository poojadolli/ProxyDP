using StateDP.Model;

namespace StateDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserSession userSession = new UserSession();
            for(int i=0; i<4; i++) { userSession.ChangeState(); }

        }
    }
}