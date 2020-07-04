using System;

namespace KvUr
{
    public class calc
    {
        public double a;
        public double b;
        public double c;

    }

    public class calc2 : calc
    {
        public double D;
        public double x;
        public double x1;
        public double x2;
        public void reshenie()
        {
            D = b*b - 4 * a * c;
            if (D < 0){
                Console.WriteLine("Решений нет");
            }
            else if (D == 0){
                x = (-b) / (2 * a);
                Console.WriteLine("Один корень: " + x);
            }
            else if (D > 0){
                x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Первый корень: " + x1);
                x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Второй корень: " + x2);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            Console.WriteLine("Введите а: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            C = Convert.ToDouble(Console.ReadLine());
            calc2 n = new calc2();
            n.a = A;
            n.b = B;
            n.c = C;
            n.reshenie();
            Console.ReadKey(); 
        }
    }
}
