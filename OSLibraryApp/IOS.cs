using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLibraryApp
{
    public interface IOS
    {
        public string UserFullName { get; set; }
        public string ShowOS();
    }
}
