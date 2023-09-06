using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan4
{
    class HinhTron 
    {
        private ToaDo tam;

        internal ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }

        public double tinhChuVi()
        {
            return Math.PI * 2 * BanKinh;
        }

        public double tinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
        
        public void input()
        {
            Console.WriteLine("\nNhap ban kinh: ");
            banKinh = double.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("Ban kinh {0}", banKinh);
            Console.WriteLine("Dien tich {0}", Math.Round(tinhDienTich(),3));
            Console.WriteLine("Chu vi {0}", Math.Round(tinhChuVi(), 3));
        }
    }
}
