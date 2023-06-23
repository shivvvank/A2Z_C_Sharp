using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern7(int n)
    {
        for(int i=1;i<=n;i++)
        {
            // no of spaces = ((2n-1)-(2i-1))/2 = n-i
            for(int j=1;j<=n-i;j++)
            {
                Console.Write(" ");
            }
            for(int j=1;j<=(2*i-1);j++)
            {
                Console.Write("*");
            }
            for(int j=1;j<=n-i;j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){

        
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern7(n);
      }
   }
}