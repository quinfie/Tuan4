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
            ToaDo td = new ToaDo();
            td.nhap();
            td.xuat();
            Console.ReadLine();
        }
    }
}
