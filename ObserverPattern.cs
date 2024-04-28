using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.DAOs;
using YameStore.Models;

namespace YameStore
{
    // Interface cho inventory observer
    public interface IInventoryObserver
    {
        void UpdateInventory(Product product);
    }

    public class Inventory
    {
        private List<IInventoryObserver> _observers = new List<IInventoryObserver>();
        private List<Product> _items;

        public Inventory()
        {
            _items = new List<Product>();
        }

        public void RegisterObserver(IInventoryObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IInventoryObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers(Product product)
        {
            foreach (var observer in _observers)
            {
                observer.UpdateInventory(product);
            }
        }
        public void PurchaseItem(Product product)
        {
            // Xử lý mua hàng
            // Sau khi mua hàng xong, cập nhật lại số lượng hàng trong kho
            // Sau khi cập nhật xong, thông báo cho tất cả các observer
            // về việc số lượng hàng trong kho đã thay đổi
            var item = _items.FirstOrDefault(i => i.Name == product.Name);
            if (item != null)
            {
                item.Quantity--;
                NotifyObservers(item);
            }
        }
    }

    // Concrete Observer thi hành IInventoryObserver
    public class InventoryManager : IInventoryObserver
    {
        private Inventory _inventory;
        private Form _form;

        public InventoryManager(Inventory inventory, Form form)
        {
            _inventory = inventory;
            _form = form;
            _inventory.RegisterObserver(this);
        }

        // Phương thức này gọi từ nút "Thanh toán" trên form
        public void CheckOut(Product product)
        {
            _inventory.PurchaseItem(product);
        }

        public void UpdateInventory(Product product)
        {
            MessageBox.Show(_form, $"Cảnh báo: Sản phẩm {product.Name} chỉ còn lại {product.Quantity} trong kho.", "Thông Báo Kho Hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Ví dụ Form chứa nút thanh toán
    public partial class InventoryForm : Form
    {
        private InventoryManager _inventoryManager;
        private Inventory _inventory;

        public InventoryForm()
        {
            _inventory = new Inventory();
            _inventoryManager = new InventoryManager(_inventory, this);
            InitializeComponent();
        }

        // Sự kiện được gọi khi nhấn nút "Thanh toán"
        private void btnPay_Click(object sender, EventArgs e)
        {
            _inventoryManager.CheckOut(#Bỏ Product cần thanh toán zô); // Giả định người dùng muốn thanh toán sản phẩm "Apple"
        }
    }
}
