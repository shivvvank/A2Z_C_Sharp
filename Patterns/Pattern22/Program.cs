using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern22(int n)
    {
        // total = 2*n-1, space = (2n-1)-(2i-1) 

        for(int i=1;i<=2*n-1;i++)
        {
            for(int j=1;j<=2*n-1;j++)
            {
                Console.Write(Math.Max(Math.Abs(i-n),Math.Abs(j-n))+1);
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern22(n);
      }
   }
}