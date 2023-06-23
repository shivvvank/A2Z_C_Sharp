using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern11(int n)
    {
        int t =1;
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(t);
                if(t==0)
                {
                    t=1;
                }
                else
                {
                    t=0;
                }
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