using System.Buffers;
using System.Diagnostics;
using System.Numerics;

namespace Example {
    class Example {

        static void RearrangePosNeg(ref int[] a,int n)
        {
            int[] ans = new int[n];
            int pos = 0,neg = 1;
            for(int i=0;i<n;i++)
            {
                if(pos>=n||neg>=n)
                    return;
                if(a[i]<0)
                {
                    ans[neg]=a[i];
                    neg+=2;
                }
                else
                {
                    ans[pos]=a[i];
                    pos+=2;
                }
            }
            for(int i=0;i < n;i++)
            {
                a[i]=ans[i];
            }
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
            RearrangePosNeg(ref a,n);
            System.Console.WriteLine("Array after rearranging : ");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}