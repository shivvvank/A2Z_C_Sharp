using System.Numerics;

namespace Example {
   class Example {

    public static void Pattern6(int n)
    {
        for(int i=0;i<n;i++)
        {
            for(int j=1;j<=(n-i);j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }    
    public static void Main(string[] args){

        
            int n = Convert.ToInt32(Console.ReadLine());
            Pattern6(n);
      }
   }
}