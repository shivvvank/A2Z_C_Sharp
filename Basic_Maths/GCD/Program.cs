namespace Example {
   class Example {

    static int gcd(int a,int b)
    {
        if(a==0)
            return b;
        if(a>b)
            return gcd(b,a);
        if(b==0)
            return a;
        else
        {
            return gcd(b%a,a);
        }
    }
      public static void Main(string[] args){
         int n = Convert.ToInt32(Console.ReadLine());
         int m = Convert.ToInt32(Console.ReadLine());
         System.Console.WriteLine("GCD : "+gcd(n,m));
      }
   }
}