using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Перше число:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Операція: ");
                    string sign = Console.ReadLine();
                    Console.WriteLine("Друге число:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Calculator cal = new Calculator(a, sign, b);
                    cal.Check();

                }
                catch (Exception)
                {

                    Console.WriteLine("Виник виняток!");
                }

                

            }
        }
    }
    class Calculator
    {
        public double FirstNum { get; set; }
        public string Sign { get; set; }
        public double SecondNum { get; set; }
        public double M1(double a, double b)
        {
            double result = a + b;
            return result;
        }
        public double M2(double a, double b)
        {
            double result = a - b;
            return result;
        }
        public double M3(double a, double b)
        {
            double result = a * b;
            return result;
        }
        public double M4(double a, double b)
        {
            double result = 0;
            if (b != 0)
            {
                result = result + (a / b);
            }
            else
            {
                Console.WriteLine("Ділити на нуль не можна");
            }
            return result;
        }
        public void Check()
        {
            if (Sign == "+")
            {
                M1(FirstNum, SecondNum);
                Console.WriteLine($"{M1(FirstNum, SecondNum)}");
            }
            else if (Sign == "-")
            {
                M2(FirstNum, SecondNum);
                Console.WriteLine($"{M2(FirstNum, SecondNum)}");
            }
            else if (Sign == "*")
            {
                M3(FirstNum, SecondNum);
                Console.WriteLine($"{M3(FirstNum, SecondNum)}");
            }
            else if (Sign == "/")
            {
                M2(FirstNum, SecondNum);
                Console.WriteLine($"{M2(FirstNum, SecondNum)}");
            }
            else
            {
                Console.WriteLine("Недоступно!");
            }
        }
        public Calculator(double a, string s, double b)
        {
            this.FirstNum = a;
            this.Sign = s;
            this.SecondNum = b;
        }
    }
}
