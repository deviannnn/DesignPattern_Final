using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YameStore.Models;

namespace YameStore.Screen.POS
{
    public partial class PosForm : Form, IInventoryObserver
    {
        private InventoryWarning _inventoryWarning;
        public PosForm()
        {
            InitializeComponent();
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
            new CheckoutDialog().ShowDialog();
        }

        private void exchangesMenuBtn_Click(object sender, EventArgs e)
        {
            new ScanInvoiceDialog().ShowDialog();
        }
    }
}
