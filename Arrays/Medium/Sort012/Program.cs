namespace Example {
    class Example {

        static void Sort012(ref int[] a,int n)
        {
            int low=0,mid=0,high=n-1;
            while(mid<=high)
            {
                if(a[mid]==0)
                {
                    swap(ref a[low],ref a[mid]);
                    low++;
                    mid++;
                }
                else if(a[mid]==1)
                {
                    mid++;
                }
                else
                {
                    swap(ref a[mid], ref a[high]);
                    {
                        high--;
                    }
                }
            }
        }
        static void swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
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
            System.Console.WriteLine("Array without Sorting : ");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
            Sort012(ref a,n);
            System.Console.WriteLine("Array with Sorting");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}