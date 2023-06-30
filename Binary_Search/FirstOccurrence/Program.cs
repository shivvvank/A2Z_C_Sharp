using System.Buffers;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Numerics;

namespace Example {
    class Example {


        // 1 2 2 2 2 3 3 4 5
        static int FirstOccurrence(int[] a,int n,int k)
        {
            int ans = -1,left=0,right=n-1;
            while(left<=right)
            {
                int mid = left + (right-left)/2;
                if(a[mid]==k)
                {
                    ans=mid;
                    right = mid-1;
                }
                else if(a[mid]<k)
                {
                    left = mid+1;
                }
                else
                {
                    right = mid-1;
                }
            }
            return ans;
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
            int x = FirstOccurrence(a,n,k);
            if(x!=-1)
                System.Console.WriteLine("First occurrence of "+a[x]+" found at index : "+x);
            else 
                System.Console.WriteLine("Element not present in array !");
        }
    }
}