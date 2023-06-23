using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern11(int n)
    {
        int counter =1;
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(counter++ +" ");
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