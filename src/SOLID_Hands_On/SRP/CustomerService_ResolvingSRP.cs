using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP.Resolving;
using static SRP.CustomerService_ViolatingSRP;

namespace SRP
{
    public class CustomerService_ResolvingSRP
    {
        //To adhere to SRP, we can separate the responsibilities into two classes:

        public class CustomerRepository : CustomerRepositoryBase
        {
        }

        public class EmailService : EmailServiceBase
        {
        }

        //Now, the CustomerRepository class handles database operations,
        //while the EmailService class manages email-related tasks.
        //Each class has a single responsibility, making it more maintainable and less prone to unexpected changes.
    }
}
