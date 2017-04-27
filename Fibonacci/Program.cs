using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new FibonacciSequence();
            foreach(var item in sequence.Take(100))
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadLine();
        }
    }
}
