using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    /// <summary>
    /// In this example, CustomerService violates SRP because it combines two distinct responsibilities—managing customer data and   sending emails. 
    /// If either of these responsibilities changes, the class requires modification, potentially causing unforeseen issues.
    /// </summary>
    public class CustomerService_ViolatingSRP
    {
        public void AddCustomer(Customer customer)
        {
            // Code to add a customer to the database
        }

        public void SendEmailToCustomer(Customer customer)
        {
            // Code to send an email to the customer
        }

        public class Customer
        {
        }
    }
}
