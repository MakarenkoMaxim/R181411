using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 54675654;
            uint b = 352543; // b > 0
            float c = 3.4f;
            double g = 3.76567887654567876543456d;
            long d = 76543245654356789;
            ulong e = 6543456765678765678; // e > 0
            decimal m = 5364759.75436m;

            string s = "text";
            char ch = 'c';

            bool l = false; // false or true

            var v = 48;
            var k = "fdgsub";

            object o = 56;
            object y = "liguyv";

            char[] t = { 't', 'e', 'x', 't' };
            var j = new System.Collections.Generic.List<char>(); ///////////////////////
            a = a > 7 ?  10 :  5;


            while (true)
            {
                int x = a;
                break;
            }

            do
            {
                int p = a;
                break;
            } while (true);

            for(int r= 7; r!=0; r--)
            {
                int q = a;
                break;
            }

            char w = t[1];
            foreach( char CH in t)
            {
                Console.WriteLine(CH);
            }

            int h = int.Parse(Console.ReadLine().ToString());

        }
    }
}
