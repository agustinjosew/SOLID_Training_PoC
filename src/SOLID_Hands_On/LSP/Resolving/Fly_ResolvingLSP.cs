using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Resolving
{
    public class Fly_ResolvingLSP
    {
        public class Bird : IFly_ResolvingLSP
        {
            public void Fly()
            {
                Console.WriteLine("A bird can fly!.");
            }
        }

        public class Ostrich : IFly_ResolvingLSP 
        {
            public void Fly()
            {
                Console.WriteLine("An ostrich can´t fly.!");
            }        
        }

        // By introducing the IFlyable interface, both Bird and Ostrich classes adhere to LSP,
        // as they provide consistent and substitutable behavior for the Fly method.
    }
}
