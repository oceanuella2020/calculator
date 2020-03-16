using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            number1 = Int32.Parse(Console.ReadLine());
            number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(number1.ToString()+"+"+ number2.ToString()+"=" + (number1 + number2).ToString());
            Console.ReadLine();

        }
    }
}
