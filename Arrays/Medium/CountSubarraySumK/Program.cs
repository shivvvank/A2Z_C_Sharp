using System.Numerics;

namespace Example {
    class Example {

        static int CountSubArraySumK(int[] a,int n ,int k)
        {
            int count = 0,sum=0;
            Dictionary<int,int> preSum = new Dictionary<int, int>();
            preSum[0]=1;
            for(int i=0;i<n;i++)
            {
                sum+=a[i];
                int rem = sum-k;
                if(preSum.ContainsKey(rem))
                {
                    count+=preSum[rem];
                }
                if(!preSum.ContainsKey(sum))
                    preSum.Add(sum,1);
                else
                    preSum[sum]++;
            }
            return count;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Enter target sum : ");
            int k = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Count subarray sum K : "+CountSubArraySumK(a,n,k));
        }
    }
}