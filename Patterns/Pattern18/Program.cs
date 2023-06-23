using System.Collections.Generic;
using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern18(int n)
    {
        char c = (char)('A'+ n-1);
        for(int i=1;i<=n;i++)
        {
            for(int j=n-i;j<n;j++)
            {
                Console.Write((char)('A'+j));
            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        Pattern18(n);
      }
   }
}