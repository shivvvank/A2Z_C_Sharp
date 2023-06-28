using System.Runtime.Intrinsics.X86;

namespace Example {
    class Example {

        static int FindMissingNumber(int[] a,int n)
        {
            int sum = 0;
            foreach(int i in a)
            {
                sum += i;
            }
            int exp = Convert.ToInt32((n*(n+1))/2);
            exp = exp-sum;
            return exp;
        }
        public static void Main(string[] args){

            Console.WriteLine("Enter n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n-1];
            System.Console.WriteLine("Enter "+(n-1)+" array elements");
            for(int i=0;i<n-1;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Missing Number : " + FindMissingNumber(a,n));
        }
    }
}