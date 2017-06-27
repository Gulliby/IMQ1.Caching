using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMQ1.Caching.Fibonacci.Executor
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciGenerator = new Library.Fibonacci();
            Console.WriteLine(fibonacciGenerator.Generate(7));
        }
    }
}
