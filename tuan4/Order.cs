using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan4
{
    class Order
    {
        protected int orderID;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        protected DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        public Order()
        {
            this.OrderID = 0;
            this.orderDate = DateTime.Parse("01/02/1234");
        }

        public Order(int orderID, DateTime orderDate)
        {
            this.OrderID = orderID;
            this.OrderDate = orderDate;
        }
        public void nhapO()
        {
            Console.WriteLine("Nhap ma hoa don: ");
            orderID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay lap hoa don: ");
            orderDate = DateTime.Parse(Console.ReadLine());
        }
    }
}
