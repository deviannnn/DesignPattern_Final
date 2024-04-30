using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.DAOs;
using YameStore.Models;

namespace YameStore.Controllers
{
    public class CustomerController
    {
        private static readonly CustomerDAO customerDAO = new();
        public static Customer GetPercentDisount(string identifier = "", int type = 0)
        {
            try
            {
                Customer? customer = customerDAO.GetByIdentifier(identifier);
                if (customer == null)
                    throw new Exception("Customer does not exist.");

                if (customer.PercentDiscount > 0.10 && type == 0)
                    customer.PercentDiscount = 0.10;

                return customer;
            }
            catch
            {
                throw;
            }
        }
    }
}
