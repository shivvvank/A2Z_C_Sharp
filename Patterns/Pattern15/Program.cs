using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern11(int n)
    {
        for(int i=1;i<=n;i++)
        {
            int counter =0;
            for(int j=1;j<=(n-i+1);j++)
            {
                Console.Write((char)('A'+(counter++)));
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