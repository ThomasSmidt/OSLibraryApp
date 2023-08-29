using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLibraryApp
{
    public class Linux : OS, IOS
    {
        public Linux(string userFullName) : base(userFullName)
        {
        }
        public override string ShowOS()
        {
            return "Welcome to Linux!";
        }
    }
}
