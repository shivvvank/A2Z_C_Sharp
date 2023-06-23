using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern20(int n)
    {
        // total = 2*n-1, space = (2n-1)-(2i-1) 

        for(int i=1;i<=n;i++)
        {
            for(int j=0;j<i;j++)
            {
                Console.Write("*");
            }
            for(int j=0;j<2*(n-i);j++)
            {
                Console.Write(" ");
            }
            for(int j=0;j<i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for(int i=n;i>=1;i--)
        {
            for(int j=0;j<i;j++)
            {
                Console.Write("*");
            }
            for(int j=0;j<2*(n-i);j++)
            {
                Console.Write(" ");
            }
            for(int j=0;j<i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){

        
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern20(n);
      }
   }
}