using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToaDo td = new ToaDo();
            //td.nhap();
            //td.xuat();
            //HinhTron ht = new HinhTron();
            //ht.input();
            //ht.output();
            //Console.ReadLine();
            ChuyenXeNoiThanh a = new ChuyenXeNoiThanh();
            ChuyenXeNoiThanh x = new ChuyenXeNoiThanh("A02", "Vo Thi Thuong", 234, 12, 200, 1233445);
            a.output();
            x.output();
            ChuyenXeNgoaiThanh b = new ChuyenXeNgoaiThanh();
            ChuyenXeNgoaiThanh y = new ChuyenXeNgoaiThanh("B02", "Tran Thi Ngoc", 234, "Ninh Binh", 500, 2235);
            b.output();
            y.output();
            Console.ReadLine();
        }
    }
}
