using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLibraryApp
{
    public class Windows : OS, IOS
    {
        public Windows(string userFullName) : base(userFullName)
        {
        }
        public override string ShowOS()
        {
            return "Welcome to Windows!";
        }
    }
}
