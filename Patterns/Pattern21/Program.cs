using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern21(int n)
    {
        // total = 2*n-1, space = (2n-1)-(2i-1) 

        for(int i=1;i<=n;i++)
        {
            if(i==1||i==n)
            {
                for(int j=1;j<=n;j++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.Write("*");
                for(int j=1;j<=(n-2);j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern21(n);
      }
   }
}