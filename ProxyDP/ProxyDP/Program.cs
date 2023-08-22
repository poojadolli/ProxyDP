using ProxyDP.Model;

namespace ProxyDP
{

   public class Program
    {
        static void Main(string[] args)
        {
            User authorizedUser = new User("Alice", true);
            User unauthorizedUser = new User("Bob", false);

            IFile secureFile = new FileProxy("SecureFile");

            secureFile.AccessFile(authorizedUser); 
            secureFile.AccessFile(unauthorizedUser); 
        }
    }
}
