using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bai_tap_Operators_and_Control_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bai_01();
            //Bai_02();
            //Bai_03();
            //Bai_04();
            //Bai_05();
            //Bai_06();
            //Bai_07();
            //Bai_08();
            Bai_09();
            //Bai_10();
            //Bai_11();
            Console.ReadKey();
        }
        public static void Bai_01()
        {
            Console.Write("Nhập số a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a / b = {Math.Round((a / b), 2)}");
        }
        public static void Bai_02()
        {
            Console.WriteLine("Ta có phương trình: x = y^2 + 2y + 1");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine("Với y = " + y + ", x = " + x);
            }
        }
        public static void Bai_03()
        {
            Console.Write("Nhập thời gian (giờ): ");
            int thoigian = int.Parse(Console.ReadLine());

            Console.Write("Nhập khoảng cách (km): ");
            double khoangcach = double.Parse(Console.ReadLine());

            double tocdo = khoangcach / thoigian;
            Console.WriteLine("Tốc độ theo km/h là {0} km/h", +tocdo);

            double m = tocdo * 100;
            Console.WriteLine("Tốc độ theo m/h là {0} m/h", m);
        }
        public static void Bai_04()
        {
            Console.Write("Nhập bán kính hình cầu: ");
            double r = double.Parse(Console.ReadLine());

            double S = 4 * Math.PI * r * r;
            Console.WriteLine($"Diện tích hình cầu là {S}");

            double V = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"Thể tích hình cầu là {V}");

        }
        public static void Bai_05()
        {
            Console.Write("Nhập một giá trị: ");
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                char character = input[0];
                Console.WriteLine("Đây là một ký tự");
            }
            else if (int.TryParse(input, out int number))
            {
                Console.WriteLine("Đây là một số");
            }
            else
            {
                Console.WriteLine("Đây là một chuỗi.");
            }
        }
        public static void Bai_06()
        {
            Console.WriteLine("Nhập vào số đo 3 cạnh của tam giác");
            Console.Write("Nhập số đo cạnh a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số đo cạnh b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập số đo cạnh c: ");
            double c = double.Parse(Console.ReadLine());
            if (a == b && b == c && a == c)
            {
                Console.WriteLine("Đây là tam giác đều");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Đây là tam giác cân");
            }
            else
            {
                Console.WriteLine("Đây là tam giác");
            }
        }
        public static void Bai_07()
        {
            Console.Write("Nhập vào số thứ 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 3: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 4: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 5: ");
            double e = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 6: ");
            double f = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 7: ");
            double g = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 8: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 9: ");
            double j = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ 10: ");
            double i = double.Parse(Console.ReadLine());

            double sum = a + b + c + d + e + f + g + h + j + i;
            Console.WriteLine($"Tổng 10 số vừa nhập là {sum}");

            double average = sum / 10;
            Console.WriteLine($"Trung bình của 10 số vừa nhập là {average}");
        }
        public static void Bai_08()
        {
            Console.WriteLine("Nhập vào 10 số");
            int[] a = new int[10];
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
            }
            Console.WriteLine($"Tổng của 10 số vừa nhập là {sum}");
            Console.WriteLine($"Trung bình của 10 số vừa nhập là {sum / 10}");
        }
        public static void Bai_09()
        {
            Console.Write("Nhập một số nguyên: ");
            int so = int.Parse(Console.ReadLine());

            Console.WriteLine("Bảng nhân của số nguyên vừa nhập: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{so} x {i} = {so * i}");
            }
        }
        public static void Bai_10()
        {
            Console.Write("Nhập vào một số: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{a}/{i}");
            }
        }
        public static void Bai_11()
        {
            Console.Write("Nhập vào một số: ");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= a; i++)
                if (a % i == 0) count++;
            {
                if (count > 2)
                {
                Console.WriteLine("Đây không phải là số nguyên tố");
                }
                else
                    Console.WriteLine("Đây là số nguyên tố");
            }
        }
    }
}



