using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Example {
    class Example {

        static int MaxConsOnes(int[] a,int n)
        {
            int count = 0;
            int maxi = Int32.MinValue;
            for(int i=0;i<n;i++)
            {
                if(a[i]!=1)
                {
                    count=0;
                }
                else
                {
                    count++;
                    maxi = Math.Max(maxi,count);
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
            System.Console.WriteLine("Max Consecutive Ones : " + MaxConsOnes(a,n));
        }
    }
}