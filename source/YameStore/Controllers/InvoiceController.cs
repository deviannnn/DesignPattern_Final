using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.DAOs;
using YameStore.Models;

namespace YameStore.Controllers
{
    public class InvoiceController
    {
        private static readonly InvoiceDAO invoiceDetailDAO = new();
        public static double GetDiscountVoucher(string code)
        {
            try
            {
                var invoice = invoiceDetailDAO.GetByCode(code);
                if (invoice == null)
                    return 0;

                return invoice.DiscountVoucher;
            }
            catch
            {
                throw;
            }
        }
    }
}
