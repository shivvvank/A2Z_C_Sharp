using System.Buffers;
using System.Diagnostics;
using System.Numerics;

namespace Example {
    class Example {

        static int MaxProfit(int[] a,int n)
        {
            int maxi = 0;
            int mine = Int32.MaxValue;
            for(int i=0;i<n;i++)
            {
                if(mine>a[i])
                {
                    mine=a[i];
                }
                maxi = Math.Max(maxi,a[i]-mine);
            }
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
            System.Console.WriteLine("Max Profit : "+MaxProfit(a,n));
        }
    }
}