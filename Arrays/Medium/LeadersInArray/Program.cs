using System.Diagnostics.Tracing;
using System.Numerics;

namespace Example {
    class Example {

        static List<int> Leaders(int[] a,int n )
        {
            List<int> ans = new List<int>();
            int maxi = Int32.MinValue;
            for(int i=n-1;i>=0;i--)
            {
                if(a[i]>maxi)
                {
                    maxi = a[i];
                }
                if(maxi==a[i])
                {
                    ans.Add(a[i]);
                }
            }
            ans.Reverse();
            return ans;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i < n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            List<int> ans = Leaders(a,n);
            foreach(int i in ans)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}