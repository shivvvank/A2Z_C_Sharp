namespace Example {
    class Example {

        // Method 1 
        static void Print1ToN(int i,int n)
        {
            if(i>n)
            {
                System.Console.WriteLine();
                return;
            }
            System.Console.Write(i+" ");
            Print1ToN(i+1,n);
        }
        // Method 2 - Print(n);
        static void Print1ToN_1(int i)
        {
            if(i==0)
                return;
            Print1ToN_1(i-1);
            System.Console.Write(i+" ");
        }
        public static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            Print1ToN_1(n);
        }
    }
 }