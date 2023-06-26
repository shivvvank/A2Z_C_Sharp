using System.Numerics;

namespace Example {
    class Example {

        static void ReverseArray(ref int[] a,int n,int i)
        {
            if(i>(n/2))
                return;
            swap(ref a[i],ref a[n-i-1]);
            ReverseArray(ref a,n,i+1);
        }
        static void swap(ref int a,ref int b)
        {
            int c = a;
            a=b;
            b=c;
        }
        public static void Main(string[] args){
            System.Console.WriteLine("enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter "+n+ " numbers ");
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Before Reversing");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
            ReverseArray(ref a,n,0);
            System.Console.WriteLine("After Reversing");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}