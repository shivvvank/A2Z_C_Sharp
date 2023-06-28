using System.Buffers;
using System.Numerics;

namespace Example {
    class Example {

        static int LinearSearch(int[] a,int n,int k)
        {  
            int index = -1;
            for(int i=0;i < n;i++)
            {
                if(a[i]==k)
                    return i;
            }
            return index;
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
            System.Console.WriteLine("Enter element to be searched");
            int k = Convert.ToInt32(Console.ReadLine());
            int index = LinearSearch(a,n,k);
            if(index==-1)
                System.Console.WriteLine("Couldn't find the element");
            else
            {
                System.Console.WriteLine(k+" found at index "+index);
            }
        }
    }
}