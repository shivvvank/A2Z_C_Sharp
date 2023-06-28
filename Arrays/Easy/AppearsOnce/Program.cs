using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Example {
    class Example {
        
        //Using XOR , XOR a with a = 0, XOR a with 0 = a,
        static int AppearOnce(int[] a,int n)
        {
            int ans = 0;
            for(int i=0;i<n;i++)
            {
                ans=ans^a[i];
            }
            return ans;
        }

        //Using Hashing
        static int AppearOnce2(int[] a,int n )
        {
            Dictionary<int,int> d = new Dictionary<int, int>();
            for(int i=0;i<n;i++)
            {
                if(!d.ContainsKey(a[i]))
                {
                    d.Add(a[i],1);
                }
                else
                {
                    d[a[i]]++;
                }
            }
            foreach(var i in d)
            {
                if(i.Value==1)
                    return i.Key;
            }
            return -1;
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
            System.Console.WriteLine("Number that appear once : " + AppearOnce2(a,n));
        }
    }
}