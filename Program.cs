using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetominka
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle first = new Rectangle();
            Console.Write("первый катет: ");
            first.length = Convert.ToDouble(Console.ReadLine());
            Console.Write("второй катет: ");
            first.width = Convert.ToDouble(Console.ReadLine());
            Rectangle.rect_calcule(first.length, first.width);
            Rectangle.rect_perim_calcule(first.length, first.width);
            Pair number = new Pair();
            Console.ReadLine();
        }
    }
    public class Rectangle : Pair
    {
        public double length;
        public double width;

        public static void rect_calcule(double x, double y)
        {
            Console.WriteLine("Площадь: " + x * y * 2);
        }
        public static void rect_perim_calcule(double x, double y)
        {
            Console.WriteLine("Гипотенуза: " + ((x + y) /2));
        }

    }

    public class Pair
    {
        public double firstNumber;
        public double secondNumber;

        public static void multiply(double x, double y)
        {
            Console.WriteLine("Multiply: " + x * y);
        }
    }
}

