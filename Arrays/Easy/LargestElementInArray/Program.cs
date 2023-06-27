using System.Numerics;

namespace Example {
    class Example {

        static int LargestElement(ref int[] a,int n )
        {
            int max = Int32.MinValue;
            for(int i=0;i<n;i++)
            {
                max = Math.Max(max,a[i]);
            }
            return max;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            System.Console.WriteLine("Enter Array elements");
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Largest Element : "+LargestElement(ref a, n));
        }
    }
}