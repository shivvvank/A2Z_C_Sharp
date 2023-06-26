namespace Example {
    class Example {

        static void PrintFibonacci(ref int[] a,int n)
        {
            if(n==0)
            {
                a[n]=0;
                return;
            }
            if(n==1)
            {
                a[n]=1;
                PrintFibonacci(ref a,0);
                return;
            }
            PrintFibonacci(ref a,n-1);
            PrintFibonacci(ref a,n-2);
            a[n] = a[n-1]+a[n-2]; 
        }
        public static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n+1];
            PrintFibonacci(ref a,n);
            foreach(int i in a)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();
        }
    }
}