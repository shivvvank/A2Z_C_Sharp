using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern5(int n)
    {
        for(int i=0;i<n;i++)
        {
            for(int j=n-i-1;j>=0;j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){

        
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern5(n);
      }
   }
}