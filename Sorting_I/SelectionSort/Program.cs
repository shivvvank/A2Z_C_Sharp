namespace Example {
    class Example {

        static void SelectionSort(ref int[] a,int n)
        {
            for(int i=0;i<n;i++)
            {
                int min_i = i;
                for(int j = i;j<n;j++)
                {
                    if(a[j]<a[min_i])
                    {
                        min_i=j;
                    }
                }
                swap(ref a[i],ref a[min_i]);
            }
        }
        static void swap(ref int a,ref int b)
        {
            int c = a;
            a=b;
            b=c;
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
            SelectionSort(ref a,n);
            System.Console.WriteLine("Array with Sorting");
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}