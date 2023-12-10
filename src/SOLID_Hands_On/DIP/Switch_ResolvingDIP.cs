using DIP.Resolving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    //To adhere to DIP, we can introduce an abstraction (interface) for the switchable
    //device and inject it into the Switch_ResolvingDIP class:
    public class Switch_ResolvingDIP
    {
        private readonly ISwitchable device;
        public Switch_ResolvingDIP(ISwitchable device)
        {
            this.device = device;
        }

        public void Toggle()
        {
            if (device.IsOn)
                device.TurnOff();
            else
                device.TurnOn();
        }
        
    }
    //By introducing the ISwitchable interface and injecting it into the Switch_ResolvingDIP class,
    //we adhere to DIP, promoting loose coupling and enabling flexibility in choosing different switchable devices.
}
