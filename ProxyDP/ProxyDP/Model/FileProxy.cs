using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDP.Model
{
    public class FileProxy : IFile
    {
        private RealFile _realFile;
        private string _filename;

        public FileProxy(string filename)
        {
            _filename = filename;
        }

        public void AccessFile(User user)
        {
            if (user.HasPermission)
            {
                if (_realFile == null)
                {
                    _realFile = new RealFile(_filename);
                }
                _realFile.AccessFile(user);
            }
            else
            {
                Console.WriteLine($"User {user.Name} does not have permission to access file {_filename}");
            }
        }
    }
    }

  
