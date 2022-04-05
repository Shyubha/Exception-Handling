using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day4
{
    public interface ICustomer
    {
        string DisplayDetails();
    }

    public interface IOrder
    {
        string DisplayDetails();
    }

    // Explicit call
    public class Transaction : ICustomer, IOrder
    {
        string ICustomer.DisplayDetails()
        {
            return "Customer Details";
        }

        string IOrder.DisplayDetails()
        {
            return "Order Deatils";
        }
    }
}
