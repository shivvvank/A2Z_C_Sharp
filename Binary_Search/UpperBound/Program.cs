using System.Buffers;
using System.Diagnostics;
using System.Numerics;

namespace Example {
    class Example {

        // 2 3 4 6 7 9 12 16 17
        static int Upper_Bound(int[] a,int n,int k)
        {
            int ans = -1, start = 0, end = n-1;
            while(start<=end)
            {
                int mid = start+(end-start)/2;
                if(a[mid]>k)
                {
                    end = mid-1;
                }
                else
                {
                    ans=mid;
                    start = mid+1;
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
            int x = Upper_Bound(a,n,k);
            if(x!=-1)
                System.Console.WriteLine("Upper bound of "+k+" is : "+a[x]);
            else 
                System.Console.WriteLine("There is no Upper bound for "+k);
        }
    }
}