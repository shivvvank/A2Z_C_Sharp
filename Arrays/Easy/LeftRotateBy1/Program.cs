using System.Buffers;
using System.Numerics;

namespace Example {
    class Example {

        // 1 2 3 3 3 3 3
        // 
        static void LeftRotateBy1(ref int[] a,int n)
        {  
            int temp = a[0];
            for(int i=0;i < n-1;i++)
            {
                a[i]=a[i+1];
            }
            a[n-1]=temp;
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
            LeftRotateBy1(ref a, n);
            System.Console.WriteLine("Array after left rotation.");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}