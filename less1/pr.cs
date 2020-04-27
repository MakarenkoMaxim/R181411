using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProjectEuler
{
    [Serializable]

    // project struct
    // functions
    // debuging
    // standart classses c#
    // git codes

    public class pr
    {
        int a;
        int b;

        int oper(int A, int B)
        {
            int C = A * B + B;
            return C;
        } 

        int oper2(int A, int B)
        {
            int C = oper(a, b) - A;
            return C;
        }

        int res = 1;

        int factorial(int p1)
        {
            if (p1 > 1)
            {
                res *= p1;
                return factorial(p1 - 1);
            }
            else { return res; }
        }

        
        public pr()
        {
            int c = Math.Max(11, 2);

            Console.WriteLine("hi Gitler");





            DirectoryInfo di = new DirectoryInfo("D:\\");
            File.WriteAllText("D:\\text.txt", "hi Gitler");

            if (File.Exists(di.FullName))
            {
                Console.WriteLine("file is exist");
            }

            foreach (FileInfo fi in di.GetFiles()) 
            {
                
                if (fi.FullName == "text.txt")
                {
                    Console.WriteLine(File.ReadAllText("D:\\text.txt"));
                }
            }








        }
        



    }
}
 