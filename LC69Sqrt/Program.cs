using System;

namespace LC69Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSqrt(8));
        }

        public static int GetSqrt(int num)
        {
            if (num <= 0)
            {
                return 0;
            }
            return (int)Math.Sqrt(num);
        }
    }
}
