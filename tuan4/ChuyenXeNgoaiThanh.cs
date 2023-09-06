using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan4
{
    class ChuyenXeNgoaiThanh
    {
        private string ma;

        protected string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private string hoTenTaiXe;

        protected string HoTenTaiXe
        {
            get { return hoTenTaiXe; }
            set { hoTenTaiXe = value; }
        }
        private int soXe;

        protected int SoXe
        {
            get { return soXe; }
            set { soXe = value; }
        }
        private string noiDen;

        protected string NoiDen
        {
            get { return noiDen; }
            set { noiDen = value; }
        }
        private double soKm;

        protected double SoKm
        {
            get { return soKm; }
            set { soKm = value; }
        }
        private double doanhThu;

        protected double DoanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }

        public ChuyenXeNgoaiThanh()
        {
            this.Ma = "B01";
            this.HoTenTaiXe = "Nguyen Van C";
            this.SoXe = 1234;
            this.NoiDen = "Ca Mau";
            this.SoKm = 20;
            this.DoanhThu = 23413257;
        }
        public ChuyenXeNgoaiThanh(string ma, string hoTenTaiXe, int soXe, string noiDen, double soKm, double doanhThu)
        {
            this.Ma = ma;
            this.HoTenTaiXe = hoTenTaiXe;
            this.SoXe = soXe;
            this.NoiDen = noiDen;
            this.SoKm = soKm;
            this.DoanhThu = doanhThu;
        }
        public void output()
        {
            Console.WriteLine("Ma so chuyen: " + Ma);
            Console.WriteLine("Ho ten tai xe: " + HoTenTaiXe);
            Console.WriteLine("So xe: " + SoXe);
            Console.WriteLine("Noi den: " + NoiDen);
            Console.WriteLine("So km di duoc: " + SoKm);
            Console.WriteLine("Doanh thu: " + DoanhThu);
            Console.WriteLine("========================================================");
        }
    }
}
