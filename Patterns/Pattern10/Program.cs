using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern9(int n)
    {
        for(int i=1;i<=n;i++)
        {
            // no of spaces = ((2n-1)-(2i-1))/2 = n-i
            for(int j=1;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for(int i=n-1;i>0;i--)
        {
            // no of spaces = ((2n-1)-(2i-1))/2 = n-i
            for(int j=1;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){

        
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern9(n);
      }
   }
}