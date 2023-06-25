namespace Example {
    class Example {
        
        static void PrintNTo1(int i,int n)
        {
            if(i>n)
                return;
            PrintNTo1(i+1,n);
            if(i==1)
                System.Console.WriteLine(i);
            else
            {
                System.Console.Write(i+" ");
            }
        }
        public static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            PrintNTo1(1,n);
     }
    }
 }