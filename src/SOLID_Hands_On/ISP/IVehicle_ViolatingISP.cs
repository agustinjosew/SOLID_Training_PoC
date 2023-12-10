using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IVehicle_ViolatingISP
    {
        void Drive();
        void Fly();
    }

    // In this case, the IVehicle interface violates ISP because not all vehicles can both drive and fly.
    //
    // For example, a bicycle can only be driven, and an airplane can only fly.
    //
    // Implementing the IVehicle interface in classes for these vehicles would force them to provide unnecessary and irrelevant methods.
}
