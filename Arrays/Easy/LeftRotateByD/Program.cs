using System.Buffers;
using System.Numerics;

namespace Example {
    class Example {

        static void LeftRotateByD(ref int[] a,int n,int d)
        {  
            d = d%n;
            int[] temp = new int[d];
            for(int i=0;i<d;i++)
            {
                temp[i]=a[i];
            }
            for(int i=0;i<n-d;i++)
            {
                a[i]=a[i+d];
            }
            for(int i=n-d;i<n;i++)
            {
                a[i]=temp[i-n+d];
            }
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
            System.Console.WriteLine("Enter the places to left rotate");
            int d = Convert.ToInt32(Console.ReadLine());
            LeftRotateByD(ref a,n,d);
            System.Console.WriteLine("Array after left rotation by "+d+" places.");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}