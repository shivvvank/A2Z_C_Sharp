using System.Numerics;

namespace Example {
    class Example {
        static int calcth(int[] nums, int threshhold,int k)
        {
            int sum = 0;
            for(int i=0;i<nums.Length;i++)
            {
                sum+=(int)Math.Ceiling((decimal)(nums[i]/k));
            }
            System.Console.WriteLine("num:"+k+" threshold:"+sum);
            return sum;
        }
        static int smallestDivisor(int[] nums, int threshold) {
            int i = 1,j=Int32.MinValue;
            foreach(int k in nums)
            {
                j = Math.Max(j,k);
            }
            int ans = Int32.MaxValue;
            while(i<=j)
            {
                int mid = i+(j-i)/2;
                int temp = calcth(nums,threshold,mid);
                if(temp<=threshold)
                {
                    ans=Math.Min(ans,mid);
                    i=mid+1;
                }
                else
                {
                    j=mid-1;
                }
            }
            return ans;
        }
        public static void Main(string[] args){
            Console.WriteLine("enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            for(int i=0;i<n;i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Enter threshold");
            int k = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("The minimum divisior : "+smallestDivisor(nums,k));
        }
    }
}