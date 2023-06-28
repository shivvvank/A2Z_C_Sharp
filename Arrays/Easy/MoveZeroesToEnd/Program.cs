using System.Numerics;

namespace Example {
    class Example {

        static void MoveZeroes(ref int[] a,int n)
        {  
            int j = 0;
            for(int i = 0;i<n;i++)
            {
                if(a[i]!=0)
                {
                    a[j++]=a[i];
                }
            }
            while(j<n)
            {
                a[j++]=0;
            }
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
            MoveZeroes(ref a, n);
            System.Console.WriteLine("Array after moving zeroes to end");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}