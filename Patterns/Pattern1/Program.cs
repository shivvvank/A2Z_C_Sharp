using System;

namespace Example {
   class Example1 {
        public static void Pattern1(int n)
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Pattern1(n);
        }
   }
}