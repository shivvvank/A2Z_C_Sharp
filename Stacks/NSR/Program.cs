using System.Numerics;

namespace Example {
    class Example {


        public static int[] NSR(ref int[] nums,int n )
        {
            int[] ans = new int[n];
            Stack<int> st=new Stack<int>();
            for(int i=n-1;i>=0;i--)
            {

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
            System.Console.WriteLine("NGL : ");
            int[] ans = NSR(ref nums,n);
            foreach(int i in ans)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}


// -3 -10 -4 -2 -1 -2 -6 -1 -7 -2 -9
// 2 4 2 