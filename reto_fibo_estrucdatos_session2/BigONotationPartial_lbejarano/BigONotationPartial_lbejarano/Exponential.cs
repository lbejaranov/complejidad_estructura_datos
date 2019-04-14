using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BigONotationPartial_lbejarano
{
    class Exponential
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Exponential exponential = new Exponential();
            ExponentialExampleType exponentialExampleType = ExponentialExampleType.Fibonacci;
            switch (exponentialExampleType)
            {
                case ExponentialExampleType.Fibonacci:
                    long n = 80; //8 40 80

                    long fibo1 = 0;
                    long fibo2 = 1;
                    
                    for (int i = 1; i <= n; i++)
                    {
                        fibo2 = fibo1 + fibo2;
                        fibo1 = fibo2 - fibo1;

                        //long fibonacci = exponential.Fibonacci(i);
                        //Console.WriteLine("fibonacci {0} = {1}", i, fibonacci);
                        Console.WriteLine(fibo2+"");
                    }
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("Time elapsed: {0:0.00} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();

           
        }

        /// Complexity: O(2^N)
        internal int Fibonacci(long n)
        {
            if (n < 0)
            {
                throw new Exception("n can not be less than zero");
            }
            if (n <= 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
