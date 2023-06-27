namespace Example {
    class Example {

        // 1 2 3 3 3 3 3
        // 1 
        static int RemoveDuplicates(ref int[] a,int n)
        {  
            int i = 1,j=0;
            while(j < n)
            {
                
            }
            return i-1;
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
            ;
            System.Console.WriteLine("Array after removing duplicates. Size : "+ RemoveDuplicates(ref a, n));
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}