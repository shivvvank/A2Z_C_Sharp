namespace Example {
   class Example {

    static bool CheckPrime(int n)
    {
        for(int i=2;i<=Math.Sqrt(n);i++)
        {
            if(n%i==0)
                return false;
        }
        return true;
    }
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        if(CheckPrime(n))
            System.Console.WriteLine("The number is Prime");
        else
            System.Console.WriteLine("The number is not prime");
    }
   }
}