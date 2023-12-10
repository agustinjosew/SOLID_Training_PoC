using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Resolving
{
    public interface ISwitchable
    {
        bool IsOn { get; set; }

        void TurnOn();
        void TurnOff();
    }
}
