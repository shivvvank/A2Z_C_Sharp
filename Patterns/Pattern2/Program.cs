using System.Numerics;

namespace Example {
   class Example {

        public static void Pattern2(int n)
        {
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args){
         
         int n = Convert.ToInt32(Console.ReadLine());
         Pattern2(n);
      }
   }
}
