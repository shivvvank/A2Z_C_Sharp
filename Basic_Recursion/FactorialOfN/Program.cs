namespace Example {
    class Example {

        static int FactorialOfN(int n)
        {
            if(n==0)
                return 1;
            return n*FactorialOfN(n-1);
        }
        public static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Factorial Of "+n+" is "+FactorialOfN(n));
        }
    }
}