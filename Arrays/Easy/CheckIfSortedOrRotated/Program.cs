using System.Numerics;

namespace Example {
    class Example {

        static int IsSorted(ref int[] a,int n)
        {
            int count = 0;
            for(int i=0;i<n-1;i++)
            {
                if(a[i]>a[i+1])
                    count++;
            }
            if(count==0)
                return 0;
            if(count==1&&a[0]>a[n-1])
            {
                return 1;
            }
            return -1;
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
            int ans = IsSorted(ref a, n);
            if(ans==1)
                System.Console.WriteLine("Array is Sorted and Rotated");
            else if(ans==0)
                System.Console.WriteLine("Array is sorted only");
            else
                System.Console.WriteLine("Array Is not sorted");
        }
    }
}