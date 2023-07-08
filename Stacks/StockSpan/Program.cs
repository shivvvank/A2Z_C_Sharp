using System.Numerics;

namespace Example {
    class Example {


        public static int StockSpan(ref int[] nums,int n )
        {
            int ans = 1;
            Stack<Tuple<int,int>> st = new Stack<Tuple<int, int>>();
            for(int i=0;i<n;i++)
            {   
                while(st.Count>0&&st.Peek().Item1<=nums[i])
                {
                    st.Pop();
                }
                if(st.Count>0)
                    ans=Math.Max(ans,i-st.Peek().Item2);
                st.Push(new Tuple<int, int>(nums[i],i));
            }
            return ans;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter size of the array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            System.Console.WriteLine("Enter "+n+" elements : ");
            for(int i=0;i<n;i++)
            {
                nums[i]=Convert.ToInt32(Console.ReadLine());
            }
            int ans = StockSpan(ref nums,n);
            System.Console.WriteLine("Ans : "+ans);
        }
    }
}