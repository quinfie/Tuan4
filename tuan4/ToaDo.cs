using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan4
{
    class ToaDo
    {
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private float x;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        private float y;

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public ToaDo()
        {
            this.x = 0;
            this.y = 0;
            this.ten = null;
        }
        public ToaDo(int x, int y, string ten)
        {
            this.x = x;
            this.y = y;
            this.ten = ten;
        }
        public void nhap()
        {
            Console.Write("Nhap ten toa do: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap toa do x: ");
            X = float.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            Y = float.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write("Toa do {0}({1},{2})", ten, x, y);
        }
    }
}
