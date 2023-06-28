using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Example {
    class Example {

        // Can also be done by Prefix Sum Map , i-PresumMap[rem] = length
        // check if sum already does not exist, push to map only then
        static int LongestSubarrayLength(int[] a,int n,int k)
        {
            int i = 0,j = 0,sum=a[0];
            int ans = Int32.MinValue;
            while(j<n)
            {
                while(i<=j&&sum>k)
                {
                    sum-=a[i];
                    i++;
                }
                if(sum==k)
                {
                    ans=Math.Max(ans,j-i+1);
                }
                j++;
                if(j<n)
                {
                    sum+=a[j];
                }
            }
            return ans;
        }
        public static void Main(string[] args){

            Console.WriteLine("Enter n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            System.Console.WriteLine("Enter "+(n)+" array elements");
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Enter k : ");
            int k = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Longest subarray length : " + LongestSubarrayLength(a,n,k));
        }
    }
}