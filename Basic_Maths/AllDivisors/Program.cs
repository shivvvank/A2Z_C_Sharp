namespace Example {
   class Example {

    static List<int> FindDivisors(int n)
    {
        List<int> ans = new List<int>();
        ans.Add(1);
        if(n!=1)
            ans.Add(n);
        for(int i=2;i<=Math.Sqrt(n);i++)
        {
            if(n%i==0)
            {
                ans.Add(i);
                ans.Add(n/i);
            }
        }
        ans.Sort();
        return ans;
    }
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> l = FindDivisors(n);
        foreach(int x in l)
        {
            System.Console.Write(x+" ");
        }
        System.Console.WriteLine();
    }
   }
}