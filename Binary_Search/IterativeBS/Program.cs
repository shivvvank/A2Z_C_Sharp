using System.Buffers;
using System.Diagnostics;
using System.Numerics;

namespace Example {
    class Example {

        static int BShelper1(int[] a,int start,int end,int k)
        {
            while(start<=end)
            {
                int mid = start+(end-start)/2;
                if(a[mid]==k)
                {
                    return mid;
                }
                else if(a[mid]<k)
                {
                    start=mid+1;
                }
                else
                {
                    end = mid-1;
                }
            }
            return -1;
        }
        static int BS(int[] a,int n,int k)
        {
            return BShelper1(a,0,n-1,k);
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
            System.Console.WriteLine("Enter target element : ");
            int k = Convert.ToInt32(Console.ReadLine());
            int x = BS(a,n,k);
            if(x!=-1)
                System.Console.WriteLine("ELement "+a[x]+" found at index : "+x);
            else 
                System.Console.WriteLine("Element not present in array !");
        }
    }
}