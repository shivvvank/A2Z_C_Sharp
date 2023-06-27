using System.Numerics;

namespace Example {
    class Example {

        static int SecondLargestElement(ref int[] a,int n)
        {
            int max = Int32.MinValue;
            int max_2 = Int32.MinValue;
            for(int i=0;i<n;i++)
            {
                if(max<a[i])
                {
                    max=a[i];
                }
                if(max_2<a[i]&&max!=a[i])
                {
                    max_2=a[i];
                }
            }
            return max_2;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            System.Console.WriteLine("Enter Array elements");
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            if(n>1)
                System.Console.WriteLine("Second Largest Element : "+SecondLargestElement(ref a, n));
            else
                System.Console.WriteLine("No second largest element in array");
        }
    }
}