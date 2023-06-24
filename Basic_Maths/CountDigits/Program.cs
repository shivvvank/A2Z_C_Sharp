namespace Example
{
    public class Example{

        
    public static Int64 NumOfDigits(Int64 n)
    {
        Int64 count = 0;
        while(n>0)
        {
            n=n/10;
            count++;
        }
        return count;
    } 
        public static void Main(string[] args)
        {
            Int64 n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Number of digits : "+NumOfDigits(n));
        }
    }
}