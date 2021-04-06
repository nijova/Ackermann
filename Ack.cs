using System;
using System.Diagnostics;

namespace Ackermann
{
    public static class Ackermann
    {
        public static int A(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (n == 0)
            {
                return A(m - 1, 1);
            }
            return A(m - 1, A(m, n - 1));
        }

        public static bool CheckArgs(int m, int n)
        {
            return m >= 0 && n >= 0;
        }

        public static void Wrapper(int m, int n)
        {
            if (CheckArgs(m, n))
            {
                Console.WriteLine(new string('*', 20));
                Stopwatch stopwatch = new Stopwatch();
                Console.WriteLine(string.Format("Computing A({0}, {1}):", m, n));
                stopwatch.Start();
                var result = A(m, n);
                stopwatch.Stop();
                Console.WriteLine(string.Format("Time to compute: {0}", stopwatch.Elapsed));
                Console.WriteLine(string.Format("Result: {0}", result));
            }
            else
            {
                Console.WriteLine("Arguments must be greater than or equal to zero.");
            }
        }
    }
}
