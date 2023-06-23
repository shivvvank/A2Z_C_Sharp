using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern3(int n)
    {
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){

        
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern3(n);
      }
   }
}