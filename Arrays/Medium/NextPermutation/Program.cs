using System.Buffers;
using System.Diagnostics;
using System.Numerics;

namespace Example {
    class Example {

        static int[] NextPermutation(int[] a,int n)
        {
            int[] b = new int[n];
            Array.Sort(a);
            
            return b;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Array elements");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            int[] b = NextPermutation(a,n);
            System.Console.WriteLine("Next Permutation : ");
            foreach(int i in b)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}