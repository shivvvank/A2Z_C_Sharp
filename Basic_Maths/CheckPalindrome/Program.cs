namespace Example {
   class Example {

    static bool IsPalindrome(Int64 n)
    {
        Int64 ans = 0;
        Int64 m = n;
        while(m>0)
        {
            ans=ans*10+m%10;
            m=m/10;
        }
        return ans.Equals(n);
    }
      public static void Main(string[] args){
         Int64 n = Convert.ToInt64(Console.ReadLine());
        if(IsPalindrome(n))
            System.Console.WriteLine("It is Palindrome");
        else
        {
            System.Console.WriteLine("Its not Palindrome");
        }
      }
   }
}