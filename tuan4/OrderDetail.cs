using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan4
{
    class OrderDetail
    {
        private Product price;
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private Product product;

        internal Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public OrderDetail()
        {
            this.Quantity = 0;
            this.Product = null;
        }
        public OrderDetail(Product product, int quantity)
        {
            this.Quantity = quantity;
            this.Product = product;
        }
        public double calcTotalPrice()
        {
            return quantity;
        }
        public void nhapQ()
        {
            Console.WriteLine("Nhap so luong: ");
            quantity = Int32.Parse(Console.ReadLine());
        }
    }
}
