using System.Buffers;
using System.Diagnostics;
using System.Numerics;

namespace Example {
    class Example {

        static int BShelper2(int[] a,int start,int end,int k)
        {
            if(start>end)
            {
                return -1;
            }
            int mid = start+(end-start)/2;
            if(a[mid]==k)
                return mid;
            else if(a[mid]<k)
                return BShelper2(a,mid+1,end,k);
            else
                return BShelper2(a,start,mid-1,k);
        }
        static int BS(int[] a,int n,int k)
        {
            return BShelper2(a,0,n-1,k);
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
            System.Console.WriteLine("Enter target element : ");
            int k = Convert.ToInt32(Console.ReadLine());
            int x = BS(a,n,k);
            if(x!=-1)
                System.Console.WriteLine("ELement "+a[x]+" found at index : "+x);
            else 
                System.Console.WriteLine("Element not present in array !");
        }
    }
}