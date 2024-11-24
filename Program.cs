using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai1();
            Bai2();
        }
        static void Bai1()
        {
            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
        static void Bai2()
        {
            int i = 0;
            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
