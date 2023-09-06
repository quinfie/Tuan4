using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan4
{
    class Product
    {

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string productID;

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product()
        {
            this.Description = null;
            this.ProductID = null;
            this.Price = 0;
        }
        public Product(string description, string productID, double price)
        {
            this.Description = description;
            this.ProductID = productID;
            this.Price = price;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap ma san pham: ");
            productID = Console.ReadLine();
            Console.WriteLine("Nhap mo ta: ");
            description = Console.ReadLine();
            Console.WriteLine("Nhap don gia: ");
            price = double.Parse(Console.ReadLine());
        }
        public void InputList(Product[] p, int n)
        {

            for (int i = 0; i < n; i++)
            {
                p[i] = new Product();
                p[i].nhap();
            }
        }
        public void OutputList(Product[] p, int n)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("STT   |  Ma SP  |           Mo Ta            |       Don Gia        |      So Luong    |     Thanh Tien     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < n; i++)
            {
                string formattedLine = string.Format("  {0,-5}| {1,-34}| {2,-18:N2}| {3,-22}| {4,-21}| {5,-16}VNĐ",
                                                  i++, p[i].ProductID, p[i].Description, p[i].Price);
                Console.WriteLine(formattedLine);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            }

        }

    }
}
