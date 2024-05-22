using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Number 1: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Please Enter Number 2: ");
            float num2 = float.Parse(Console.ReadLine());
            float sum = num1 + num2;
            float avg = sum / 2;
            if (avg > num1)
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }
            Console.ReadKey();
        }
    }
}
