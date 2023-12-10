using ISP.Resolving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Vehicle_ResolvingISP
    {
    }
    // To adhere to ISP, we should create more specific interfaces tailored to each type of vehicle

    public class Bicycle : IDrivable
    {
        public void Drive()
        {
            return;
        }
    }

    public class Airplane : IFlyable
    {
        public void Fly()
        {
            return;
        }
    }

    // By introducing separate interfaces (IDrivable and IFlyable),
    // we adhere to ISP, ensuring that clients are not forced to implement methods they do not need.
    // This promotes a more granular and flexible approach to interface usage and class design.
}
