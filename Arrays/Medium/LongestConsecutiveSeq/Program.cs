using System.Buffers;
using System.Diagnostics.Tracing;
using System.Numerics;

namespace Example {
    class Example {

        static int LConsSeq(int[] a,int n )
        {
            // 1 Soution is to sort and find 
            Dictionary<int,int> d = new Dictionary<int, int>();
            for(int i=0;i<n;i++)
            {
                if(!d.ContainsKey(a[i]))
                {
                    d.Add(a[i],1);
                }
            }
            int maxi = Int32.MinValue;
            for(int i=0;i<n;i++)
            {
                int count = 1,cur = a[i],nxt=cur+1;
                while(d.ContainsKey(nxt))
                {
                    count++;
                    nxt++;
                }
                maxi = Math.Max(maxi,count);
            }
            return maxi;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i < n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Longest consecutive sequence "+LConsSeq(a,n));
        }
    }
}