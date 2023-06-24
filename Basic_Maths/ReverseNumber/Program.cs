using System;

namespace Example {
   class Example {

    static Int64 ReverseNumber(Int64 n)
    {   
        Int64 ans=0;
        while(n>0)
        {
            ans=ans*10+n%10;
            n=n/10;
        }
        return ans;
    }
    public static void Main(string[] args){
         Int64 n = Convert.ToInt64(Console.ReadLine());
         System.Console.WriteLine("Number : "+n);
         System.Console.WriteLine("Reverse : "+ReverseNumber(n));
    }
   }
}