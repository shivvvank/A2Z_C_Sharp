using System.Buffers;
using System.Numerics;
using System.Threading.Tasks.Sources;

namespace Example {
    class Example {

        static void QuickSort(ref int[] a,int n)
        {
            QuickSorthelper(ref a,0,n-1);
        }
        static int Partition(ref int[] a,int low,int high)
        {
            int pivot = low;
            int i = low,j=high;
            while(i<j)
            {
                while(a[i]<=a[pivot]&&i<=high-1)
                {
                    i++;
                }
                while(a[j]>a[pivot]&&j>=low+1)
                {
                    j--;
                }
                if(i<j)
                {
                    swap(ref a[i],ref a[j]);
                }
            }
            swap(ref a[j],ref a[pivot]);
            return pivot;
        }
        static void QuickSorthelper(ref int[] a,int low,int high)
        {
            if(low>=high)
                return;
            int pivot = Partition(ref a,low,high);
            QuickSorthelper(ref a,low,pivot-1);
            QuickSorthelper(ref a,pivot+1,high);
        }
        static void swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
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
            System.Console.WriteLine("Array without Sorting : ");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
            QuickSort(ref a,n);
            System.Console.WriteLine("Array with Sorting");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}