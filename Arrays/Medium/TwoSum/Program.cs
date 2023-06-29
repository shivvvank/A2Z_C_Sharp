using System.Buffers;
using System.Numerics;

namespace Example {
    class Example {

        static List<int> TwoSum(int[] a,int n,int k)
        {
            List<int> l = new List<int>();
            l.Add(-1);
            l.Add(-1);
            Dictionary<int,int> m = new Dictionary<int, int>(); //assuming all elements appear once 
            for(int i=0;i<n;i++)
            {
                m.Add(a[i],i);
            }
            for(int i=0;i<n;i++)
            {
                int t = k-a[i];
                if(m.ContainsKey(t)&&m[t]!=i)
                {
                    l[0]=i;
                    l[1]=m[t];
                }
            }
            return l;
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
            System.Console.WriteLine("Enter target : ");
            int k = Convert.ToInt32(Console.ReadLine());
            List<int> l = TwoSum(a,n,k);
            if(l[0]!=-1)
                System.Console.WriteLine("Target Exists at position "+(l[0]+1)+" & "+(l[1]+1));
            else
            {
                System.Console.WriteLine("Target do not exist");
            }
        }
    }
}