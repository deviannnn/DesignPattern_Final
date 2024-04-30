using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YameStore.Controllers;
using YameStore.Models;
using YameStore.Screen.Initial;

namespace YameStore.Screen.POS
{
    public partial class PosForm : Form, IInventoryObserver
    {
        private InventoryWarning _inventoryWarning;
        private static PosForm? instance;
        public static PosForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PosForm();
                }
                return instance;
            }
        }
        public double CustomerDiscountPercent { get; set; }
        SaleInvoice saleInvoice;
        private PosForm()
        {
            InitializeComponent();
            tbxCashierName.Text = UserSession.Instance.Account.Name;
            saleInvoice = new OriginInvoice();
        }

        public void Update(List<ProductSize> updatedItems)
        {
            string notify = "";
            foreach (var p in updatedItems)
            {
                if (p.Quantity < 10)
                    notify += $"Product {p.ProductID} is running low on stock. Current quantity: {p.Quantity}\n";
            }
            MessageBox.Show(this, notify, "InventoryWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            new PayDialog().ShowDialog();
            // Sau thành toán thành công và đóng PayDialog

            // Lấy danh sách sản phẩm vừa bán ra
            List<ProductSize> listPurchaseItems = new();

            _inventoryWarning = new StockWarning();
            _inventoryWarning.RegisterObserver(this);
            ((StockWarning)_inventoryWarning).PurchaseItem(listPurchaseItems);
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var checkoutDialog = new CheckoutDialog())
            {
                if (checkoutDialog.ShowDialog() == DialogResult.OK)
                {
                    tbxCustomerPercentDiscount.Text = $"{checkoutDialog.CheckoutCustomer.PercentDiscount}";
                    tbxCustomerName.Text = checkoutDialog.CheckoutCustomer.Name;
                    saleInvoice = new DiscountCustomer(saleInvoice, checkoutDialog.CheckoutCustomer.PercentDiscount);
                }
            }
        }

        private void tbxVoucher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var discount = InvoiceController.GetDiscountVoucher(tbxVoucher.Text);
                if (discount != 0)
                {
                    saleInvoice = new DiscountVoucher(saleInvoice, discount);
                    tbxVoucher.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exchangesMenuBtn_Click(object sender, EventArgs e)
        {
            new ScanInvoiceDialog().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
