using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    public abstract class Platform
    {
        public Platform()
        {
        }
        
        public abstract void WriteMessage(string Message);
    }
}
