using System;

namespace LessCode
{
    class Program
    {
        static void Main(string[] args)
        {
            uint res = 0;
            for (uint i = 1001; i != 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    res += i;
                }
            }
            Console.WriteLine(res);
        }
    }
}
