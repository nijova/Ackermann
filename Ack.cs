using System;

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
                Console.WriteLine(A(m, n));
            }
            else
            {
                Console.WriteLine("Arguments must be greater than or equal to zero.");
            }
        }
    }
}
