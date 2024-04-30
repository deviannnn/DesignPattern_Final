using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.Models;

namespace YameStore
{
    public abstract class SaleInvoice
    {
        public abstract double GetCost();
    }

    public class OriginInvoice : SaleInvoice
    {
        private List<ProductSize> cart;
        private double TotalAmount { get; set; }
        public OriginInvoice()
        {
            cart = new List<ProductSize>();
        }

        public void AddToCart(ProductSize ps, int quantity)
        {
            ProductSize existingProduct = cart.FirstOrDefault(p => p.ID == ps.ID);
            if (existingProduct != null)
            {
                existingProduct.Quantity += quantity;
            }
            else
            {
                ps.Quantity = quantity;
                cart.Add(ps);
            }

            UpdateAmount();
        }

        public void DeleteFromCart(ProductSize ps, int quantity)
        {
            ProductSize existingProduct = cart.FirstOrDefault(p => p.ID == ps.ID);
            if (existingProduct != null)
            {
                if (existingProduct.Quantity > quantity)
                {
                    existingProduct.Quantity -= quantity;
                }
                else
                {
                    cart.Remove(existingProduct);
                }
            }

            UpdateAmount();
        }

        private void UpdateAmount()
        {
            double totalAmount = 0;
            foreach (var item in cart)
            {
                totalAmount += item.Quantity * item.Product.Price;
            }
            TotalAmount = totalAmount;
        }

        public override double GetCost()
        {
            return TotalAmount;
        }
    }

    public abstract class SurchargeDecorator : SaleInvoice
    {
        protected SaleInvoice wrapObj;
        protected SurchargeDecorator(SaleInvoice wrapObj)
        {
            this.wrapObj = wrapObj;
        }
    }

    public class DiscountCustomer : SurchargeDecorator
    {
        private double Surcharge;
        public DiscountCustomer(SaleInvoice wrapObj, double discount) : base(wrapObj) 
        {
            Surcharge = discount;
        }
        public override double GetCost()
        {
            return wrapObj.GetCost() - Surcharge;
        }
    }

    public class DiscountVoucher : SurchargeDecorator
    {
        private double Surcharge;
        public DiscountVoucher(SaleInvoice wrapObj, double discount) : base(wrapObj)
        {
            Surcharge = discount;
        }
        public override double GetCost()
        {
            return wrapObj.GetCost() - Surcharge;
        }
    }
}
