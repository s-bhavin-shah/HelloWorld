using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    public class PlatformConsole : Platform
    {
        public override void WriteMessage(string Message)
        {
            Console.WriteLine(Message);
            Console.ReadLine();
        }
    }
}
