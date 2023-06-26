namespace Example {
    class Example {

        static int SumFirstN(int n)
        {
            if(n==0)
                return 0;
            return n + SumFirstN(n-1);
        }
        public static void Main(string[] args){
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("The sum of first "+n+" numbers is "+SumFirstN(n));
        }
    }
}
