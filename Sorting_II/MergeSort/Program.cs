using System.Buffers;
using System.Numerics;

namespace Example {
    class Example {

        static void MergeSort(ref int[] a,int n)
        {
            MergeSorthelper(ref a,0,n-1);
        }
        static void Merge(ref int[] a,int low,int mid,int high)
        {
            int[] temp = new int[high-low+1];
            int i = low,j=mid+1,k=0;
            while(i<=mid&&j<=high)
            {
                if(a[i]<=a[j])
                {
                    temp[k++]=a[i++];
                }
                else
                {
                    temp[k++]=a[j++];
                }
            }
            while(i<=mid)
            {
                temp[k++]=a[i++];
            }
            while(j<=high)
            {
                temp[k++]=a[j++];
            }
            i=0;
            for(int b = low;b<=high;b++)
            {
                a[b]=temp[i++];
            }
        }
        static void MergeSorthelper(ref int[] a,int low,int high)
        {
            if(low==high)
            {
                return;
            }
            int mid = low+(high-low)/2;
            MergeSorthelper(ref a,low,mid);
            MergeSorthelper(ref a,mid+1,high);
            Merge(ref a,low,mid,high);
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
            MergeSort(ref a,n);
            System.Console.WriteLine("Array with Sorting");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}