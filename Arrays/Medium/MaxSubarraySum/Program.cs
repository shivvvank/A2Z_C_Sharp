using System.Buffers;
using System.Diagnostics;
using System.Numerics;

namespace Example {
    class Example {

        static int MaxSubarraySum(int[] a,int n)
        {
            int sum = 0,maxi = Int32.MinValue;
            int istart = 0, iend = 0,start=0;
            for(int i=0;i<n;i++)
            {
                if(sum==0)
                    start=i;
                sum+=a[i];
                if(maxi<sum)
                {
                    maxi = sum;
                    iend=i;
                    istart=start;
                }
                if(sum<0)
                {
                    sum=0;
                }
            }
            //printing subarray
            for(int i=istart;i <=iend ;i++)
            {
                System.Console.Write(a[i]+" ");
            }
            System.Console.WriteLine();
            return maxi;
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
            System.Console.WriteLine("Max Subarray Sum : "+MaxSubarraySum(a,n));
        }
    }
}