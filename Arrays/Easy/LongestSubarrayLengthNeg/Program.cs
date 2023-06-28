using System.Numerics;

namespace Example {
    class Example {

        // Can also be done by Prefix Sum Map , i-PresumMap[rem] = length
        // check if sum already does not exist, push to map only then
        static int LongestSubarrayLengthNeg(int[] a,int n,int k)
        {
            int sum = 0;
            int maxi = Int32.MinValue;
            Dictionary<int,int> preSum = new Dictionary<int, int>();
            for(int i=0;i<n;i++)
            {
                sum+=a[i];
                if(sum==k)
                {
                    maxi=Math.Max(maxi,i+1);
                }
                int rem = sum-k;
                if(preSum.ContainsKey(rem))
                {
                    maxi = Math.Max(maxi,i-preSum[rem]);
                }
                if(!preSum.ContainsKey(sum))
                {
                    preSum.Add(sum,i);
                }
            }
            return maxi;
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
            System.Console.WriteLine("Longest subarray length : " + LongestSubarrayLengthNeg(a,n,k));
        }
    }
}