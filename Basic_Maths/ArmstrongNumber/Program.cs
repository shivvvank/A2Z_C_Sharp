namespace Example {
   class Example {

    static bool IsArmstrong(Int64 n)
    {
        string s = n.ToString();
        Int64 d = s.Length;
        Int64 ans = 0;
        Int64 m = n;
        while(m>0)
        {
            ans+=(Int64)Math.Pow(m%10,d);
            m=(Int64)m/10;
        }
        return ans==n;
    }
    public static void Main(string[] args){
        Int64 n = Convert.ToInt64(Console.ReadLine());
        if(IsArmstrong(n))
            System.Console.WriteLine("This is Armstrong number");
        else
            System.Console.WriteLine("This is not Armstrong number"); 
    }
   }
}