using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.DAOs;
using YameStore.Models;

namespace YameStore
{
    public interface IInventoryObserver
    {
        void Update(List<ProductSize> listPS);
    }

    public abstract class InventoryWarning
    {
        protected List<IInventoryObserver> _observers = new();
        public void RegisterObserver(IInventoryObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void UnregisterObserver(IInventoryObserver observer)
        {
            _observers.Remove(observer);
        }

        public abstract void Notify(List<ProductSize> updatedItems);
    }

    public class StockWarning : InventoryWarning
    {
        private List<ProductSize> _items;

        public StockWarning()
        {
            _items = new ProductSizeDAO().GetAll();
        }

        public override void Notify(List<ProductSize> updatedItems)
        {
            foreach (var observer in _observers)
            {
                observer.Update(updatedItems);
            }
        }

        public void PurchaseItem(List<ProductSize> listPurchaseItems)
        {
            // Xử lý mua hàng
            // Sau khi mua hàng xong, cập nhật lại số lượng hàng trong kho
            // Sau khi cập nhật xong, thông báo cho tất cả các observer
            // về việc số lượng hàng trong kho đã thay đổi

            // Danh sách sản phẩm đã được cập nhật sau khi mua hàng
            List<ProductSize> updatedItems = new List<ProductSize>();

            foreach (var p in listPurchaseItems)
            {
                var item = _items.FirstOrDefault(i => i.ProductID == p.ProductID);
                if (item != null)
                {
                    item.Quantity -= p.Quantity; // Giảm số lượng của sản phẩm trong _items bằng số lượng của sản phẩm đó trong listPS
                    updatedItems.Add(item); // Thêm sản phẩm đã được cập nhật vào danh sách updatedItems
                }
            }

            // Thông báo chỉ một lần với danh sách sản phẩm đã cập nhật
            Notify(updatedItems);
        }  
    }
}