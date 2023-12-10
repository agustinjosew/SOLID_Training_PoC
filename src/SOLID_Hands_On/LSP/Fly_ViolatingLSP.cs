using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Fly_ViolatingLSP
    {
        public virtual void Fly()
        {
            Console.WriteLine("A bird can fly!.");
        }
    }

    public class Ostrich : Fly_ViolatingLSP
    {
        public override void Fly()
        {
            throw new InvalidOperationException("Ostriches can't fly.");
        }
    }

    // In this example, the Ostrich class violates LSP because it alters the behavior of the base class's Fly method,
    // which is unexpected behavior for a subclass.
}
