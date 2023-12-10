using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Switch_ViolatingDIP
    {
        public class LightBulb
        {
            public bool IsOn { get; internal set; }

            public void TurnOn()
            {
                // Code to turn on the light bulb
            }

            public void TurnOff()
            {
                // Code to turn off the light bulb
            }
        }

        public class Switch
        {
            private readonly LightBulb bulb;

            public Switch()
            {
                bulb = new LightBulb();
            }

            public void Toggle()
            {
                if (bulb.IsOn)
                    bulb.TurnOff();
                else
                    bulb.TurnOn();
            }
        }

        //In this example, the Switch class violates DIP by directly depending on a concrete implementation,
        //making it inflexible and tightly coupled.
    }
}
