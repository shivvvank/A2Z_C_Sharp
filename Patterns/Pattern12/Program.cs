using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern11(int n)
    {
        // total = 2*n, number = i+i, space = 2*(n-i), i ->1-n
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(j);
            }
            for(int j=1;j<=2*(n-i);j++)
            {
                Console.Write(" ");
            }
            for(int j=i;j>=1;j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){

        
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern11(n);
      }
   }
}