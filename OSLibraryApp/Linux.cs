using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLibraryApp
{
    internal class Linux : OS, IOS
    {
        public Linux(string userFullName) : base(userFullName)
        {
        }
        public string ShowOS()
        {
            return "Welcome to Linux!";
        }
    }
}
