using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDP.Model
{
    public class RealFile : IFile
        {
            private string _filename;

            public RealFile(string filename)
            {
                _filename = filename;
                Console.WriteLine($"Creating real file: {_filename}");
            }
           public void AccessFile(User user)
            {
                Console.WriteLine($"Accessing file {_filename} for user {user.Name}");
            }
        }
    }

