using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorldConsole
{
    public class PlatformSelection
    {
        public enum PlatformEnum
        {
            Console,
            Database,
            Windows,
            Web,
            Phone
        };

        private PlatformEnum _selectedPlatform;
        public PlatformEnum SelectedPlatform
        {
            get { return _selectedPlatform; }
            set { _selectedPlatform = value; }
        }

        private string _message = "Hello World";
        
        public PlatformSelection()
        {
            if (ConfigurationManager.AppSettings["UseAPI"].ToString() == "1")
            {
                _message = CallHelloWorldAPI.CallRestMethod();
            }

            string _platform = ConfigurationManager.AppSettings["Platform"];
            SelectedPlatform = (PlatformEnum)Enum.Parse(typeof(PlatformEnum), _platform);
            switch (SelectedPlatform) { 
                case PlatformEnum.Console:
                    Platform platform = new PlatformConsole();
                    platform.WriteMessage(_message);
                    break;
                case PlatformEnum.Database:
                    break;
                case PlatformEnum.Phone:
                    break;
                case PlatformEnum.Web:
                    break;
                case PlatformEnum.Windows:
                    break;
            };
        }
    }
}
